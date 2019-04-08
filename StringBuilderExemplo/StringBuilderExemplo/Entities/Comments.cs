using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilderExemplo.Entities
{
    class Comments
    {
        public String Text { get; set; }

        public Comments()
        {
        }

        public Comments(string text)
        {
            this.Text = text;
        }
    }
}
