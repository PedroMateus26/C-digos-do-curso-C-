using System;
using System.Collections.Generic;

namespace ConceitosdeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            List<String> list2 = new List<String> {"Maria", "Bob"};
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Maria");
            list.Add("Anna");
            list.Insert(2,"Marco");
            foreach(String obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Tamano da lista "+list.Count);
            String s1 = list.Find(x=>x[0]=='A');
            Console.WriteLine("Primeiro A "+s1);
            String s2 = list.FindLast(x=>x[0]=='A');
            Console.WriteLine("Último da lista com 'A': "+s2);
            int pos1 = list.FindIndex(x=>x[0] == 'A');
            Console.WriteLine("First position "+pos1);
            int pos2 = list.FindLastIndex(x=>x[0]=='A');
            Console.WriteLine("Last Position "+pos2);
            List<String> list3 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("===========================");
            list.RemoveRange(2, 2);
            foreach (String obj in list3) Console.WriteLine(obj);
            /*foreach (String obj in list3) Console.WriteLine(obj);
            Console.WriteLine("===========================");
            list.RemoveAt(3);
            foreach (String obj in list) Console.WriteLine(obj);
            Console.WriteLine("===========================");
            list.RemoveAll(x=>x[0]=='M');
            foreach (String obj in list) Console.WriteLine(obj);
            list.RemoveRange(2,2);
            */

        }
    }
}
