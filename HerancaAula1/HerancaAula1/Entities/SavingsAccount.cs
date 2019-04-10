using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaAula1.Entities
{
    class SavingsAccount : Accounts
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int numbers, string holder, double balance, double interestRate) : base (numbers, holder, balance)
        {
            this.InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            this.Balance *= InterestRate;
        }
    }
}
