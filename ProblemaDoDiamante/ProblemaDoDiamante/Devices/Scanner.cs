using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDoDiamante.Devices
{
    class Scanner : Device, IScaner
    {

        public override void processDoc(string document)
        {
            Console.WriteLine("Scanner processing: " );
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
