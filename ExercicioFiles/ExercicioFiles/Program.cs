using System;
using System.IO;
using ExercicioFiles.Entity;

namespace ExercicioFiles
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os itens, com seus valores e quantidade separados por virgula");
            string sourcefilepath = Console.ReadLine();
            

            try
            {
                string[] lines = File.ReadAllLines(sourcefilepath);
                string sourceFolderPath = @"C:\Users\pedro\Desktop\Nova pasta(2)";
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);
                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);
                        Product product = new Product(name, price, quantity);
                        sw.WriteLine(product.Name + "," + product.total());
                        
                    }


                }

            }catch(IOException e)
            {
                Console.WriteLine("An error ocurred. "+e.Message);
            }
        }
    }
}
