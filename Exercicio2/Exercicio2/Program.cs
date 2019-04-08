using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Exercício 1
            Console.WriteLine("Entre com um valor inteiro");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0) Console.WriteLine("O número é negativo");
            else Console.WriteLine("O número é positivo");
            */
            /*//Exercício 2
            Console.WriteLine("Entre com um valor");
            int valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0) Console.WriteLine("O valor é par");
            else Console.WriteLine("O valor é impar");
            */
            /*//Exercício 3
            int valor1;
            int valor2;
            do
            {
                Console.WriteLine("Digite doi valor inteiros em ordem crescente");
                valor1 = int.Parse(Console.ReadLine());
                valor2 = int.Parse(Console.ReadLine());
                if (valor2 % valor1 == 0) Console.WriteLine("Os valores são multiplos");
                if (valor1 > valor2) Console.WriteLine("Você digitou os valores em ordem decrescente. Repita o processo por favor");
            } while (valor1 > valor2);
            */
            /*//Exercício 4 
            Console.WriteLine("Digite a hora inicial do jogo");
            int hora1 = int.Parse(Console.ReadLine());
            int hora2 = int.Parse(Console.ReadLine());
            int total = 0;
            if (hora1 > hora2) total = (24 + hora2) - hora1;
            else if (hora1 == hora2) total = 24;
            else total = hora2 - hora1;
            Console.WriteLine("Toal de horas jogadas "+ total);
            */
            /*//Exercício 5
            Console.WriteLine("Entre com o código do produto");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade desejada");
            int quantidade = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());
            if (a == 1)
            {
                valor = 4.00;
                Console.WriteLine("Produto escolhido cachorro quente" + quantidade+ " quantidade valor a " +
               "pagar " + ((double)(a * valor)));
            }
            else if (a == 2)
            {
                 valor= 4.50;
                Console.WriteLine("Produto escolhido xsalada" + quantidade+ " quantidade valor a " +
               "pagar " + ((double)(a * valor)));
            }
            else if(a==3)
            {
                valor = 5.0;
                Console.WriteLine("Produto escolhido cachorro quente" + quantidade + " quantidade valor a " +
              "pagar " + ((double)(a * valor)));
            }*/
            /*//Exercício 6
            Console.WriteLine("Digite um valor");
            double valor = int.Parse(Console.ReadLine());
            if (valor >= 0 && valor <= 25) Console.WriteLine("Valor dentro do intervalo de 0 a 25");
            else if (valor > 25 && valor <= 50) Console.WriteLine("Valor dentro do intervalo de 25 a 50");
            else if (valor > 50 && valor <= 75) Console.WriteLine("Valor dentro do intervalo de 50 a 75");
            else if (valor > 75 && valor <= 100) Console.WriteLine("Valor dentro do intervalo de 75 a 100");
            else Console.WriteLine("Valor fora do intervalo");
            */
            /*//Exercício 7
            Console.WriteLine("Digite dois valores quaisquer");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && y >= 0) Console.WriteLine("Valores estão no primeiro quadrante");
            else if (x < 0 && y >= 0) Console.WriteLine("Valores estão no segundo quadrante");
            else if (x < 0 && y < 0) Console.WriteLine("Valores estão no terceiro quadrante");
            else if (x > 0 && y < 0) Console.WriteLine("Valores estão no quarto quadrante");
            */
            //Exercício 8







        }
    }
}
