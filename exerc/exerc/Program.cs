using System;

namespace exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV",500.00,10);
            Console.WriteLine(p.Nome);
            /*
            Console.WriteLine("Entre com os dados do produto ");
            Console.WriteLine("Nome ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preco ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());
            */
        }
    }
}
