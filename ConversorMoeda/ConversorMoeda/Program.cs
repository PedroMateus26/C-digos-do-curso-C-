using System;

namespace ConversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor da cotação ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Entre com a quantidade em reais ");
            double reais = double.Parse(Console.ReadLine());
            double total = ConversorDeMoeda.Conversor(cotacao, reais);
            Console.WriteLine("O valor total em reais é "+total);
        }
    }
}
