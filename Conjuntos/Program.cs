using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);
            /*
            foreach (int x in A) ;
            foreach (int y in B) ;
             */

            /*Console.WriteLine("Digite um valor inteiro");
            int b = int.Parse(Console.ReadLine());
            if (B.Contains(b)) Console.WriteLine("O cunjunto já possui o valor");
            else
            {
                Console.WriteLine("O valor não está no conjunto e será adicionado");
                B.Add(b);
                
            }
            /* foreach (int a in B) 
             Console.WriteLine(a);
             Console.WriteLine();
             B.Remove(6);
             foreach (int a in B)
             Console.WriteLine(a);
             */
            //A.ExceptWith(B);
            //A.UnionWith(B);
            A.IntersectWith(B);
            foreach (int a in A) Console.WriteLine(a);
        }
    }
}
