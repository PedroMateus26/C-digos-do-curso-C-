using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaAula1.Entities
{
    class Accounts
    {
        public int Numbers { get; protected set; }
        public String Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Accounts()
        {

        }

        public Accounts(int numbers, string holder, double balance)
        {
            Numbers = numbers;
            Holder = holder;
            Balance = balance;
        }

      public void WithDraw(double amount)
        {
            this.Balance -= amount; 
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
