using System;
using ExcecaoProposto.Entities;
using ExcecaoProposto.Entities.Exception;

namespace ExcecaoProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                String holder = Console.ReadLine();
                Console.Write("Initial balace: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Witdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, withdrawLimit);
                Console.WriteLine("\n");
                Console.Write("Enter with the amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);
                Console.WriteLine("Balce now: " + acc.Balance);
            }
            catch (Limit l)
            {
                Console.WriteLine(l.Message);
            }
            catch (MinimumBalance mb)
            {
                Console.WriteLine(mb.Message);
            }
            catch (NegativeValue nv)
            {
                Console.WriteLine(nv.Message);
            }

        }
    }
}
