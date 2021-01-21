using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
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
        public override void calculateInterest()
        {
            if (AccountType.Equals(BankAccountTypeEnum.Current))
            {
                Console.WriteLine("Interest is not available in Current account");
                return;
            }
            double interest = 0.5 * base.balance; //HSBC 5% interest rate
            Console.WriteLine("The interest amount is: " + interest);
        }
    }
}
