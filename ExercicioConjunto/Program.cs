using System;
using System.Collections.Generic;


namespace ExercicioConjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> D = new HashSet<int>();

            Console.WriteLine("Digite a quantidade de alunos para o curso A");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n ; i++)
            {
                Console.WriteLine("Digite o aluno número " + (i+1)+" do curso A");
                int j = int.Parse(Console.ReadLine());
                A.Add(j);
            }
            Console.WriteLine("Digite a quantidade de alunos para o curso B");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite o aluno número " + (i + 1) + " do curso B");
                int j = int.Parse(Console.ReadLine());
                B.Add(j);
            }
            Console.WriteLine("Digite a quantidade de alunos para o curso C");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Digite o aluno número " + (i + 1) + " do curso C");
                int j = int.Parse(Console.ReadLine());
                C.Add(j);

            }


            D.UnionWith(A);
            D.UnionWith(B);
            D.UnionWith(C);
            
            Console.WriteLine("A no total "+D.Count+" conjunto");

        }
    }
}
