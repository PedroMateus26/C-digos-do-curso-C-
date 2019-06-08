using ProblemaDoDiamante.Devices;
using System;

namespace ProblemaDoDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.processDoc("My letter");
            printer.printer("My letter");
            printer.Color = "Azul";
            Console.WriteLine(printer.Color);

            Scanner s = new Scanner()
            {
                SerialNumber=2003
            };

            s.processDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.processDoc("My dissertation");
            c.printer("My dissertation");
            Console.WriteLine(c.Scan());

        }
    }
}
