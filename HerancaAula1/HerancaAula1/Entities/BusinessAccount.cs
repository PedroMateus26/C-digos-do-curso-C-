using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaAula1.Entities 
{
    class BusinessAccount : Accounts
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int numbers, string holder, double balance, double loanLimit) : base(numbers,  holder, balance)
        {
            this.LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount<= LoanLimit)
            this.Balance = amount;
        }
    }
}
