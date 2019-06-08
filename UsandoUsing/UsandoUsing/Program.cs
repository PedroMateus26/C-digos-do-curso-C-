using System;
using System.IO;

namespace UsandoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pedro\Desktop\Nova pasta (2)\file.txt";
            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //    using (StreamReader sr = new StreamReader(fs))
                //    {
                //        while (!sr.EndOfStream)
                //        {
                //            string line = sr.ReadLine();
                //            Console.WriteLine(line);
                //        }
                //    }
                //}

                using (StreamReader sr = File.OpenText(path))
                {


                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred. " + e.Message);
            }
        }
    }
}
