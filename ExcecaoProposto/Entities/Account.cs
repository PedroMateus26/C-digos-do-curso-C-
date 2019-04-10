using System;
using System.Collections.Generic;
using System.Text;
using ExcecaoProposto.Entities.Exception;

namespace ExcecaoProposto.Entities.Exception
{
    class Account
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (number <= 0 || balance <= 0 || withdrawLimit <= 0)
            {
                throw new NegativeValue("Error! Doesn't permited negative value");
            }
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
            this.WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            if (amount<0)
            {
                throw new NegativeValue("Error! Doesn't permited negative value");
            }
            this.Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount<0)
            {
                throw new NegativeValue("Error! Doesn't permited negative value");
            }
            if (amount > this.Balance)
            {
                throw new MinimumBalance("Error! Not enough balance");
            }
            if (amount > this.WithdrawLimit)
            {
                throw new Limit("Error! The amount exceeds the withdraw limit");
            }
            this.Balance -= amount;
        }
    }
}
