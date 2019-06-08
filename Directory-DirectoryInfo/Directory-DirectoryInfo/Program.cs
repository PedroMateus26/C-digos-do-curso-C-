using System;
using System.IO;
//using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pedro\Desktop\Nova pasta (2)";
            try
            {
                //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine();
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\new folder");
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred. "+e.Message);
            }

        }
    }
}
