using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
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

        public override void calculateInterest()
        {
            if(AccountType.Equals(BankAccountTypeEnum.Current))
            {
                Console.WriteLine("Interest is not available in Current account");
                return;
            }    
            double interest = 0.7 * base.balance; //ICICI 7% rate given
            Console.WriteLine("The interest amount is: " + interest);
        }
    }
}
