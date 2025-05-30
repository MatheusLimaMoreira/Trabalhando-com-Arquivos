namespace Directory_and_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\MyFolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string S in folders)
                {
                    Console.WriteLine(S);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string S in files)
                {
                    Console.WriteLine(S);
                }

                Directory.CreateDirectory(path + @"\NewFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
