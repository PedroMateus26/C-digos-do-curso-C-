using System;

namespace NullAble
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StructTeste s;
            s.X = 10.0;
            Console.WriteLine(s.X);
            double? z = null;
            Console.WriteLine(z.HasValue);
            Console.WriteLine(z.Value);
            */
            double? x = null;
            double? y = 10;
            double a = x ?? 5;
            double b = y ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
