using System;

namespace ExpressaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do preço");
            double preco = double.Parse(Console.ReadLine());
            double desconto = (preco<20.0)?preco*0.1:preco*0.05; // Essa forma é alternativa ao if e else
            /*if (preco < 20.0)
             {
                 desconto = preco * 0.1;

             }
             else
             {
                 desconto = preco*0.05;
                 Console.WriteLine();
             }
             */
            Console.WriteLine(desconto);
        }
    }
}
