using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    public class BankBranch : IBankBranch
    {
        private int branchNumber;
        private string address;
        private CheckingAccount[] accounts;

        public BankBranch(int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
            this.accounts = new CheckingAccount[20];
        }
        // add to account array 
        public void AddAccount(CheckingAccount account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    return;
                }
            }

            Console.WriteLine("Cannot add account: Branch account list is full.");
        }

        // print accounts function
        public void PrintAccounts()
        {
            for(int i = 0;i < accounts.Length;i++)
            {
                if (accounts[i] != null)
                {
                    Console.WriteLine($"{accounts[i].GetAccountNumber()}, {accounts[i].GetCustomerOwner()}, {accounts[i].GetBalance()}");

                }
            }
        }
    }
}
