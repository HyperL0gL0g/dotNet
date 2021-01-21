using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public abstract class BankAccount:IBankAccount
    {
        protected double balance;
        
        private BankAccountTypeEnum accountType;
        public abstract double getBalance(); 
        public void deposite(double amount)
        {
            balance += amount;
        }
        public abstract bool withDraw(double amount);
        public abstract bool transfer(IBankAccount toAccount, double amount);

        public abstract void calculateInterest();
        public BankAccountTypeEnum AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            } 
        }
    }
}
