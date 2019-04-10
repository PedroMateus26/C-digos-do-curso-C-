using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecaoProposto.Entities.Exception
{
    class NegativeValue : ApplicationException
    {
        public NegativeValue(String message) : base(message)
        {

        }
    }
}
