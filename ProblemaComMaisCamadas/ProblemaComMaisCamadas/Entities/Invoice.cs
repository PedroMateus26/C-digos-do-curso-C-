using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProblemaComMaisCamadas.Entities
{
    class Invoice
    {
        public double BasicPayments { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayments, double tax)
        {
            BasicPayments = basicPayments;
            Tax = tax;
        }

        public double TotalPayments
        {
            get{ return BasicPayments + Tax;}
        }

        public override string ToString()
        {
            return "BasicPayments: "+this.BasicPayments.ToString("F2")
                +"\nTax: "+this.Tax.ToString("F2")
                +"Total Payment: "+this.TotalPayments.ToString("F2");
        }
    }
}
