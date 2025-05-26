using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{

    public class CheckingAccount : BankAccount
    {
        private const int OverdraftLimit = 1000;

        public CheckingAccount(int accountNumber, double balance, Customer customerOwner)
            : base(accountNumber, balance, customerOwner)
        {
        }

        // Overridden Withdraw method with overdraft check
        public new void Withdraw(double amount)
        {
            double currentBalance = this.GetBalance();

            if (amount > currentBalance + OverdraftLimit)
            {
                Console.WriteLine("Cannot execute the withdrawal — you've passed the overdraft limit!");
            }
            else
            {
                // Use the setter to update the balance
                this.SetBalance(currentBalance - amount);
                Console.WriteLine($"Withdrawal successful. New balance: {this.GetBalance()}");
            }
        }

        public override void PrintBalance()
        {
            double balance = this.GetBalance();
            Console.WriteLine($"Current balance: {balance}");

            if (balance < 0)
            {
                Console.WriteLine($"Overdraft used: {Math.Abs(balance)} out of {OverdraftLimit}");
            }
            else
            {
                Console.WriteLine("No overdraft in use.");
            }
        }

    }
}
