using System;

namespace Vetor1
{

    class Program
    {
        
        static void Main(string[] args)
        {
            double media = 0;
            Console.WriteLine("Entre com o número de pessoas");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] vet=new double[n];
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine("Entre com a altura");
                vet[i] = Convert.ToDouble(Console.ReadLine());
                media += vet[i];
            }
            
            Console.WriteLine("A média é "+(media / n));

        }
    }
}
