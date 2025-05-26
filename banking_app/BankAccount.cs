using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    
    
        public class BankAccount
        {
            private int accountNumber;
            private double balance;
            private Customer customerOwner;

            public BankAccount(int accountNumber, double balance, Customer customerOwner)
            {
                this.accountNumber = accountNumber;
                this.balance = balance;
                this.customerOwner = customerOwner;
            }

            // Getters
            public int GetAccountNumber()
            {
                return this.accountNumber;
            }

            public double GetBalance()
            {
                return this.balance;
            }

            public Customer GetCustomerOwner()
            {
                return this.customerOwner;
            }

            // Setters
            public void SetAccountNumber(int accountNumber)
            {
                this.accountNumber = accountNumber;
            }

            public void SetBalance(double balance)
            {
                this.balance = balance;
            }

            public void SetCustomerOwner(Customer customerOwner)
            {
                this.customerOwner = customerOwner;
            }

            // Add money to the account
            public void Deposit(double amount)
            {
                this.balance += amount;
            }

            // Withdraw money from the account
            public void Withdraw(double amount)
            {
                this.balance -= amount;
            }

            public virtual void PrintBalance()
            {
                Console.WriteLine($"Hello {this.customerOwner.GetName()}, your balance is = {this.balance}");
            }
        }
    }

   

