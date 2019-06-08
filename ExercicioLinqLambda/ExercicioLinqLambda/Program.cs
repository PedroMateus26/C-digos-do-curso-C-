using System;
using System.IO;
using System.Collections.Generic;
using ExercicioLinqLambda.Entities;
using System.Globalization;
using System.Linq;

namespace ExercicioLinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();
            List<Product> product = new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    product.Add(new Product(name, price));
                }
            }

            var avg = product.Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Average Price= "+avg.ToString("F2"));
            var names = product.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
