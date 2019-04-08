using System;

namespace Exercicio_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1;
            c1 = new ContaBancaria("Alex Green",7800);
            c1.EstatusConta();
            c1.AbrirConta();
            Console.WriteLine();

            //c1.EstatusConta();
            //c1.Deposito(300);
            //Console.WriteLine();
            //c1.EstatusConta();
            //c1.Saque(400);
            
            //Console.WriteLine();
            //c1.EstatusConta();
        }
    }
}
