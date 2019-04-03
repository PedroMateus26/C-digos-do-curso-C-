using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Entre com o valor de n, onde n vai ser o valor da matriz quadrada");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] mat = new double[n, n];
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Entre com o elemento da linha "+(i+1)+" e da coluna "+(j+1));
                    mat[i, j] = Convert.ToDouble(Console.ReadLine());
                    if (mat[i, j] < 0) x++;
                    if(i==j) vet[i] = mat[i, j];

                }
                 
                
            }
            //Forma alternativa para mostrar diagonal principal
            Console.Write("main diagonal");
            for (int i = 0; i < n; i++) Console.WriteLine(mat[i,i]+", ");
            
            Console.WriteLine("A matriz possui "+x+" elementos negativos");

            Console.Write("a diagonal principal é ");
            for (int i = 0; i < n; i++) Console.Write(vet[i]+", ");

        }
    }
}
