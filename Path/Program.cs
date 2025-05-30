namespace PathCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\temp\MyFolder\file1.txt";


            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            Console.WriteLine("GetPathRoot: " + Path.GetPathRoot(path));
            Console.WriteLine("GetRandomFileName: " + Path.GetRandomFileName());

        }
    }
}
