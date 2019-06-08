using System;
using System.IO;

namespace FileStrem_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pedro\Desktop\Nova pasta (2)\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
                
            }catch(IOException e){
                Console.WriteLine("An error ocurred "+e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
