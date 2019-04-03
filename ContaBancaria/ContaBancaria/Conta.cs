using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ContaBancaria
{
    class Conta
    {
        public int Numero { get; private set; }
        public String Titular { get; set; }
        public double Saldo { get; set; }

        public Conta (int numero, String titular)
        {
            this.Titular = titular;
            this.Numero = numero;

        }

        public Conta(int numero, String titular, double saldo): this(numero, titular)
        {
            this.Deposito(saldo);
        }

        public void Deposito(double quantia)
        {
            this.Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            this.Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
             string Conta = string.Format( "Conta"
                +this.Numero+
                ", titular: "+
                this.Titular+
                ", saldo $"+
                this.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            return Conta;
        }

    }
}
