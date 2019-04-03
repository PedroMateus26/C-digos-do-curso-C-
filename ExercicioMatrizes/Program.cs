using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de linhas ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com o número de colunas ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um valor a ser pesquisado ");
            double x = Convert.ToDouble(Console.ReadLine());
            double[,] mat = new double[n, m];
            double w = 0; 


            for(int i = 0; i < n; i++)
            {
                for(int j=0; j < m; j++)
                {
                    Console.WriteLine("Entre com o valor da linha "+(i+1)+" e da coluna "+(j+1));
                    mat[i, j] = Convert.ToDouble(Console.ReadLine());

                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == x)
                    {
                        if (i == 0 && j == 0)
                        {
                            Console.WriteLine("A direita " + mat[i, j + 1]);
                            Console.WriteLine("A baixo " + mat[i + 1, j]);
                        }
                        else if (i == (n-1) && j == (m-1))
                        {
                            Console.WriteLine("A esquerda " + mat[i, j - 1]);
                            Console.WriteLine("A cima " + mat[i - 1, j]);
                        }
                        else if(i == 0 && j == (m - 1))
                        {
                            Console.WriteLine("A baixo " + mat[i + 1, j]);
                            Console.WriteLine("A esquerda " + mat[i, j - 1]);
                        }
                        else if(i == (n-1) && j == 0)
                        {
                            Console.WriteLine("A direita " + mat[i, j + 1]);                         
                            Console.WriteLine("A cima " + mat[i - 1, j]);
                        }
                        else if (i == 0 )
                        {
                            Console.WriteLine("A direita " + mat[i, j + 1]);
                            Console.WriteLine("A esquerda " + mat[i, j - 1]);
                            Console.WriteLine("A baixo " + mat[i + 1, j]);
                        }
                        else if (i == (n-1))
                        {
                            Console.WriteLine("A direita " + mat[i, j + 1]);
                            Console.WriteLine("A esquerda " + mat[i, j - 1]);
                            Console.WriteLine("A cima " + mat[i - 1, j]);
                        }
                        else if (j == (m - 1))
                        {
                            Console.WriteLine("A cima " + mat[i - 1, j]);
                            Console.WriteLine("A esquerda " + mat[i, j - 1]);
                            Console.WriteLine("A baixo " + mat[i + 1, j]);
                        }
                        else if (j == 0)
                        {
                            Console.WriteLine("A direita " + mat[i, j + 1]);
                            Console.WriteLine("A esquerda " + mat[i, j - 1]);
                            Console.WriteLine("A baixo " + mat[i + 1, j]);
                        }
                        else
                        {
                            Console.WriteLine("A direita " + mat[i, j + 1]);
                            Console.WriteLine("A baixo " + mat[i + 1, j]);
                            Console.WriteLine("A esquerda " + mat[i, j - 1]);
                            Console.WriteLine("A cima " + mat[i - 1, j]);
                        }
                    }                       
                }

            }

        }
    }
}

