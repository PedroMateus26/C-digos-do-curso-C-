using System;

namespace Exemplo_membros_estáticos
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com  o valor do raio");
            double raio = double.Parse(Console.ReadLine());
            double circ = Circunferencia(raio);
            double vol = Volume(raio);
            Console.WriteLine("Circunferência "+circ+", volume "+vol);

        }



    }
}
