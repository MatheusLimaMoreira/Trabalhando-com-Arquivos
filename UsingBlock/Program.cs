namespace UsingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path)) // Usando o bloco using para garantir o fechamento do StreamReader
                {
                    while (!sr.EndOfStream) // Ler todas as linhas do arquivo
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
