using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculadora
    {
        public static double pi = 3.14;
        public static double Circunferência(double raio)
        {
            return 2 * pi * raio;
        }
        public static double Volume(double raio)
        {
            return 4 / 3 * pi * raio * raio * raio;
        }
    }
}
