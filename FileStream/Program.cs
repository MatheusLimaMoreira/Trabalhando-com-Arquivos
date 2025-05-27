using System.IO;

namespace FileStream_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\temp\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(Path, FileMode.Open);
                sr = File.OpenText(Path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
          
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
