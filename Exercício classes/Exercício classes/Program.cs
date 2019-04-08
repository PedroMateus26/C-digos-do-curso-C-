using System;

namespace Exercício_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*Retangulo r1;
             r1 = new Retangulo();
             r1.Altura = 3.00;
             r1.Largura = 4.00;
             Console.WriteLine("Area do retangulo "+ r1.area());
             Console.WriteLine("Perimetro do retangulo " + r1.perimetro());
             Console.WriteLine("Perimetro do retangulo " + r1.diagonal());
            */
            //Exercício 2
            /*Funcionario f1 = new Funcionario();
            f1.Nome="João Silva";
            f1.Salario = 6000;
            f1.Imposto = 1000;
            Console.WriteLine("funcionário "+f1.Nome+", salário de "+f1.salarioLiquido());
            Console.WriteLine("Digite ao aumento no salário do funcionário");
            double aumento = double.Parse(Console.ReadLine());
            f1.aumentarSalario(aumento);
            Console.WriteLine("Novo salário de "+f1.Nome+" equiavalente à "+f1.Salario);
            */
            //Exercício 3
            Aluno al = new Aluno();
            /*
            //Teste 1
            al.nota1 = 27.0;
            al.nota2 = 31.0;
            al.nota3 = 32.0;
            Console.WriteLine("total de pontos: "+ al.notaFinal());
            */
            //Teste 2
            al.nota1 = 17.0;
            al.nota2 = 20.0;
            al.nota3 = 15.0;
            Console.WriteLine("total de pontos: " + al.notaFinal());


        }
    }
}
