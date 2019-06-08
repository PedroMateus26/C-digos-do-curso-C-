using DelegateComparison.Entities;
using System;
using System.Collections.Generic;

namespace DelegateComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list=new List<Products>();

            list.Add(new Products("TV",900.00));
            list.Add(new Products("Notebook",1200.00));
            list.Add(new Products("Tablet",450.00));

            //Comparison<Products> comp = CompareProduct;
            
            //Comparison<Products> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //list.Sort(comp);

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Products p in list)
            {
                Console.WriteLine(p);
            }

        }

        /*static int CompareProduct(Products p1, Products p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); 

        }*/

    }

}
