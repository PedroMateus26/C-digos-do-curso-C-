using System;

namespace Exercícios_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Exercício 1
            int x = 0;
            int senha = 0;
            while (senha != 2002)
            {
                
                Console.WriteLine("Entre com a senha");
                senha = int.Parse(Console.ReadLine());
                x++;
                if (senha!=2002 && x<3) Console.WriteLine("Senha inválida, tente novamente");
                
                if (x == 3)
                {
                    Console.WriteLine("Você errou a senha mais de três vezes, tente novamente mais tarde");
                    break;
                }
            }
            Console.WriteLine("Senha correta!");*/
            /*//Exercício 2
            int x = 10;
            int y = 10;
            while (x!=0 && y != 0)
            {
                Console.WriteLine("Digite as coordenadas iniciais de x");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite as coordenadas iniciais de y");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("x = "+x+ " y = " + y);
                if (x > 0 && y > 0) Console.WriteLine("Os pontos estão no primeiro quadrante");
                if (x < 0 && y > 0) Console.WriteLine("Os pontos estão no segundo quadrante");
                if (x < 0 && y < 0) Console.WriteLine("Os pontos estão no terceiro quadrante");
                if (x > 0 && y < 0) Console.WriteLine("Os pontos estão no quarto quadrante");
                //if (x == 0 || y == 0) break;
            }*/
            //Exerecício 3
            Console.WriteLine("Digite um valor");
            int x = int.Parse(Console.ReadLine());
            while (x < 1 || x > 4)
            {
                Console.WriteLine("Valor inválido, digite novamente");
                Console.WriteLine("Digite um valor");
                x = int.Parse(Console.ReadLine());
            }
            switch (x)
            {
                case 1:
                    Console.WriteLine("Álcool");
                    break;
                case 2:
                    Console.WriteLine("Diesel");
                    break;
                case 3:
                    Console.WriteLine("Gasolina");
                    break;
                case 4:
                    Console.WriteLine("Fim");
                    break;
            }

        }
    }
}
