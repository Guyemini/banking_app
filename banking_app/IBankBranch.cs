using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    public interface IBankBranch
    {
         void AddAccount(CheckingAccount account);
         void PrintAccounts();
    }
}
