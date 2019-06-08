using System;
using LinqProjeto1.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LinqProjeto1
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> colletctions)
        {
            Console.WriteLine(message);
            foreach(T obj in colletctions)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() {

                new Product(){Id=1, Name="Computador", Price=1100.00, Category=c2} ,
                new Product(){Id=2, Name="Hammer", Price=90.00, Category=c1}       ,
                new Product(){Id=3, Name="TV", Price=1700.00, Category=c3}         ,
                new Product(){Id=1, Name="NoteBook", Price=1300.00, Category=c2}   ,
                new Product(){Id=4, Name="Saw", Price=80.00, Category=c1}          ,
                new Product(){Id=5, Name="Tablet", Price=700.00, Category=c2}      ,
                new Product(){Id=6, Name="Camera", Price=700.00, Category=c3}      ,
                new Product(){Id=7, Name="Printer", Price=350.00, Category=c3}     ,
                new Product(){Id=8, Name="MacBook", Price=1800.00, Category=c2}    ,
                new Product(){Id=9, Name="SoundBar", Price=700.00, Category=c3}    ,
            new Product() { Id = 10, Name = "Level", Price = 70.00, Category = c1 }

            };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900.0
                     select p;
            Print("Tier 1 and price<900:", r1);

            //var r2 = products.Where(p => p.Category.Name.Equals("Tools")).Select(p=>p.Name);
            var r2 = from p in products
                     where p.Category.Name == "Tools"
                     select p.Name;
            Print("Tools", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p=>new {p.Name,p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new
                     {
                         p.Name,
                         p.Price,
                         Category = p.Category.Name
                     };
            Print("Name started with C and anonymous object", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p=>p.Name);
            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;
            Print("Tier 1 order by price then by name", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Using skip", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine( "First test 1: "+r6);

            var r7 = products.Where(p => p.Price >= 3000.00).FirstOrDefault();
            Console.WriteLine("FirstOrDefault() teste 2" + r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Return id: "+r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Return id: " + r9);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: "+r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price: " + r11);

            var r12 = products.Where(p => p.Category.id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: "+r12);

            var r13 = products.Where(p => p.Category.id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            var r14 = products.Where(p => p.Category.id == 5).Select(p=>p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Category 5 Average prices: "+r14);

            var r15 = products.Where(p => p.Category.id == 1).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine("Sum r15 aggregate: "+r15);

            //var r16 = products.GroupBy(p => p.Category);
            var r16 = from p in products
                      group p by p.Category;
            Console.WriteLine();
            foreach(IGrouping<Category, Product>group in r16)
            {
                Console.WriteLine("Category: "+group.Key.Name+":");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}

