using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;
using LinqLambdaProposto.Entities;

namespace LinqLambdaProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people with salary more than "+ salary);
            List<Product> list=new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                
                    string[] vet = sr.ReadLine().Split(",");
                    string name = vet[0];
                    string email = vet[1];
                    double price = double.Parse(vet[2], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, email, price));
                }
            }

            var emails = list.Where(p => p.Price > salary).OrderBy(p => p.Email).Select(p => p.Email);
            var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Price);
            Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
