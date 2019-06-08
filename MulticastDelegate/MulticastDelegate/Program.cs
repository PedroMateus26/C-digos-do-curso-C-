using System;
using MulticastDelegate.Services;

namespace MulticastDelegate
{

    delegate void BinaryNumericOperation(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10, b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op(a, b);


        }
    }
}
