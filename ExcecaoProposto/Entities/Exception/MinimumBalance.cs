using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecaoProposto.Entities.Exception
{
    class MinimumBalance : ApplicationException
    {
        public MinimumBalance(String message) : base(message)
        {

        }
    }
}
