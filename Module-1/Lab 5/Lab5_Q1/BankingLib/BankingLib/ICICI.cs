using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    //task 7(1) ICICI bank
    public class ICICI:BankAccount
    {
        public override bool withDraw(double amount)
        {
            if (base.balance - amount < 0)
                return false;
            base.balance -= amount;
            return true;
        }
        public override double getBalance()
        {
            return base.balance;
        }
        public override bool transfer(IBankAccount toAccount, double amount)
        {
            if (base.balance - amount < 1000)
                return false;
            toAccount.deposite(amount);
            withDraw(amount);
            return true;
        }
    }
}
