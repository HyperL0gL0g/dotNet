using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    //task 7(2) HSBC bank
    public class HSBC:BankAccount
    {
        public override bool withDraw(double amount)
        {
            if (base.balance - amount < 5000)
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
            if (base.balance - amount < 5000)
                return false;
            toAccount.deposite(amount);
            this.withDraw(amount);
            return true;
        }
    }
}
