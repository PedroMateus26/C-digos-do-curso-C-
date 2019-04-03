using System;

namespace Vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número de itens");
            int n = Convert.ToInt32(Console.ReadLine());
            Product[] vect = new Product[n];
            for(int i = 0; i < n; i++)
            {
                String name = Console.ReadLine();
                double price = Convert.ToDouble(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            Console.WriteLine("A média dos valores dos produtos é "+(sum/3));
        }
    }
}
