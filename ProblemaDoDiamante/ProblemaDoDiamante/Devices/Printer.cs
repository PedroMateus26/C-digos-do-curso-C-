using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDoDiamante.Devices
{
    class Printer : Device, IPrinter
    {
        public override void processDoc(string document)
        {
            Console.WriteLine("P`rinter processing"+document);
        }

        public void printer(string document)
        {
            Console.WriteLine("Printer print "+document);
        }
    }
}
