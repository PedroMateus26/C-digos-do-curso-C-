using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDoDiamante.Devices
{
    class ComboDevice : Device, IScaner, IPrinter
    {
        public void printer(string document)
        {
            Console.WriteLine("Combo device print");
        }

        public override void processDoc(string document)
        {
            Console.WriteLine("Combo device processing "+document);
        }

        public string Scan()
        {
            return "Combo device scan result";
        }
    }
}
