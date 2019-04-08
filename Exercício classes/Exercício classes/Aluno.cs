using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_classes
{
    class Aluno
    {
        public String Nome;
        public double nota1;
        public double nota2;
        public double nota3;
        public bool Aprovado;
        public double notaFinal()          
        {
            double n = nota1 + nota2 + nota3;
            if (n < 60)
            {
                Console.WriteLine("Aluno Reprovado, faltaram "+(60-n)+" pontos");
                return n;
            }
            else
            {
                Console.WriteLine("Aluno aprovado");
                return n;
            }
        }

    }
}
