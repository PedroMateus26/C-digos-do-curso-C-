using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_classes
{
    class Funcionario
    {
        public String Nome;
        public double Salario;
        public double Imposto;

        public double salarioLiquido()
        {
            double sl = Salario - Imposto;
            return sl;
        }
        public void aumentarSalario(double porcentagem)
        {
            Salario = ((porcentagem / 100) * Salario + Salario);
            Console.WriteLine("Salario aumentado e com valor total de "+Salario); 

        }
    }
}
