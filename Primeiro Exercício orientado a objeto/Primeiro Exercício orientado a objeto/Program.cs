using System;

namespace Primeiro_Exercício_orientado_a_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();
            Console.WriteLine("Entre com o nome da primeira pessoa");
            p1.nome = Console.ReadLine();
            //Console.WriteLine("Entre com a idade da primeira pessoa");
            //p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome da segunda pessoa");
            p2.nome = Console.ReadLine();
            //Console.WriteLine("Entre com a idade da segunda pessoa");
            //p2.idade = int.Parse(Console.ReadLine());
            /*if (p1.idade > p2.idade) Console.WriteLine("A pessoa "+p1.nome+" é mais velha que a "+p2.nome);
            else Console.WriteLine("A pessoa " + p2.nome + " é mais velha que a " + p1.nome);*/
            Console.WriteLine("Entre com o salário da primeira pessoa");
            p1.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o salário da segunda pessoa");
            p2.salario = double.Parse(Console.ReadLine());
            if (p1.salario > p2.salario) Console.WriteLine("A pessoa " + p1.nome + " possui salário superior a pessoa" + p2.nome);
            else Console.WriteLine("A pessoa " + p2.nome + " possui salário superior a pessoa" + p1.nome);
        }
    }
}
