using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaDoDiamante.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void processDoc(string document);
        public string Color;

    }
}
