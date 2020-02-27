using System;
using System.IO;

namespace S9_WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy(@"c:\temp\test.jpg", @"d:\temp\test.jpg");            var path = @"c:\something.jpg;";
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var constant = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\S9_WorkWithFiles", "*.sln*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\projects\S9_WorkWithFiles", ".", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
