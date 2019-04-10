using System;

namespace HerancaAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Accounts acc = new Accounts(1001, Alex, 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            Account acc1 = bacc;
            Account acc2 = new BusinessAccoun(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);
            BusinessAccount acc4 = acc2;

        }
    }
}
