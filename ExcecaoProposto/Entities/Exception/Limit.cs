using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecaoProposto.Entities.Exception
{
    class Limit : ApplicationException
    {
        public Limit(String message) : base(message) { }
    }
}
