﻿using System;
using System.Collections.Generic;
using ActionDelegate.Entities;
using System.Linq;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
            //Func<Product, string> func = NameUpper;
            ;
            //List<String> result = list.Select(NameUpper).ToList();

            Func<Product, string> func = p=>p.Name.ToUpper();
            List<String> result = list.Select(func).ToList();

            foreach (string s in result) Console.WriteLine(s);

        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
