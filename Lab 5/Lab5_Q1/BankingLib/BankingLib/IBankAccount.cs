using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public interface IBankAccount
    {
        double getBalance();
        void deposite(double amount);
        bool withDraw(double amount);
        bool transfer(IBankAccount toAccount, double amount);
        BankAccountTypeEnum AccountType { get; set; }
    }
}
