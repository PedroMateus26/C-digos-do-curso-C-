using System;
using IntroducaoDelegate.Services;

namespace IntroducaoDelegate
{

    delegate double BinaryNumericOperation(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;



            double result = CalculationService.Square(a);
            Console.WriteLine(op(a,b));
        }
    }
}
