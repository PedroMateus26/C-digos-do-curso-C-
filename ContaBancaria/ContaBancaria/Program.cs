using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1;
            Console.WriteLine("Entre com o número da conta");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta");
            String nome = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? s para sim, s para sim e n para não");
            char resp = Convert.ToChar(Console.ReadLine());
            if(resp=='s'|| resp == 'S')
            {
                Console.WriteLine("Digite o valor do deposito inicial");
                double dep = Convert.ToDouble(Console.ReadLine());
                conta1= new Conta(numero,nome, dep);
            }
            else
            {
                conta1 = new Conta(numero,nome);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta1);
            Console.WriteLine("Entre com um valor para deposito");
            double quantia = Convert.ToDouble(Console.ReadLine());
            conta1.Deposito(quantia);
            Console.WriteLine("\n Dados da conta atualizado");
            Console.WriteLine(conta1);
            Console.WriteLine("\n Entre com um valor para saque");
            quantia = Convert.ToDouble(Console.ReadLine());
            conta1.Saque(quantia);
            Console.WriteLine("\n Dados da conta atualizado");
            Console.WriteLine(conta1);

        }
    }
}
