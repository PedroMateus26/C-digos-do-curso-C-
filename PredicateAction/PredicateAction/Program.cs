using System;
using System.Collections.Generic;
using PredicateAction.Entities;

namespace PredicateAction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();
            list.Add(new Products("Tv", 900.00));
            list.Add(new Products("Mouse", 50.00));
            list.Add(new Products("Tablet", 350.50));
            list.Add(new Products("HD Case", 80.90));

            //Action<Products> act=UpdatePrice;
            Action<Products> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(act);
            foreach (Products p in list) Console.WriteLine(p);

        }

        static void UpdatePrice(Products p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
