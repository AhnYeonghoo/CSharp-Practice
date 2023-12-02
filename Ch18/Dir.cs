using System;
using System.IO;
using System.Linq;

namespace Dir
{
    class MainApp
    {

        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type.");
            return;
        }

        static void MainDir(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage : Torch.exe <Path> [Type:File/Directory]");
                return;
            }

            string path = args[0];
            string type = "File";
            if (args.Length > 1) type = args[1];

            if (File.Exists(path) || Directory.Exists(path))
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.SetLastWriteTime(path, DateTime.Now);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Updated {path} {type}");
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Created {path} {type}");
            }

            string directory;
            if (args.Length < 1)
            {
                directory = ".";
            }
            else
            {
                directory = args[0];
            }

            Console.WriteLine($"{directory} directory Info");
            Console.WriteLine("- Directories :");
            var directories = (from dir in Directory.GetDirectories(directory)
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name = info.Name,
                                   Attributes = info.Attributes,
                               }).ToList();
            foreach (var d in directories)
            {
                Console.WriteLine($"{d.Name} : {d.Attributes}");
            }

            Console.WriteLine("- Files :");
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attributes = info.Attributes,
                         }).ToList();

            foreach (var f in files)
            {
                Console.WriteLine($"{f.Name} : {f.FileSize}, {f.Attributes}");
            }
        }
    }
}