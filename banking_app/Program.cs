using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Create customers
            Customer customer1 = new Customer(1, "David", 123456789);
            Customer customer2 = new Customer(2, "Sarah", 987654321);

            // Create checking accounts
            CheckingAccount acc1 = new CheckingAccount(1001, 500.0, customer1);
            CheckingAccount acc2 = new CheckingAccount(1002, -200.0, customer2);

            // Make some transactions
            acc1.Deposit(300);
            acc1.Withdraw(100);
            acc2.Withdraw(900);  // This should print overdraft warning

            // Print balances
            acc1.PrintBalance();
            acc2.PrintBalance();

            // Create a bank branch and add accounts
            IBankBranch branch = new BankBranch(1, "123 Main St");
            branch.AddAccount(acc1);
            branch.AddAccount(acc2);

            // Print all accounts in branch
            Console.WriteLine("\nAccounts in branch:");
            branch.PrintAccounts();

            // Print customer details
            Console.WriteLine("\nCustomer Details:");
            customer1.PrintDetails();
            customer2.PrintDetails();
        }
    }
}
