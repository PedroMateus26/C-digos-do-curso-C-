using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorMoeda
{
    class ConversorDeMoeda
    {
        public static double Conversor(double cotacao, double reais)
        {
            double total = (cotacao * reais) + (0.06* cotacao * reais);
            return total;
        }
    }
}
