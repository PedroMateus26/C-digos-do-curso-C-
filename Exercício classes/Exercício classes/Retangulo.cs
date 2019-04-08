using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_classes
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double area()
        {
            double a = Largura * Altura;
            return a;
        }
        public double perimetro()
        {
            double p = (2*Largura) + (2*Altura);
            return p;
        }
        public double diagonal()
        {
            double d = Math.Sqrt((Altura * Altura) + (Largura * Largura));
            return d;
        }
    }
}
