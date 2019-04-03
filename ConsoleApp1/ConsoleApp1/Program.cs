using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            Calculadora calc = new Calculadora();
            Console.WriteLine(Calculadora.Circunferência(raio)+" "+ Calculadora.Volume(raio));

        }
    }
}
