using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    //event practice
    public delegate void PaymentDel(double amount); //delegate declaration 
    public class CreditCard
    {
        //CreditCardNo, CardHolderName, BalanceAmount, CreditLimit.
        public event PaymentDel PaymentSuccess; //event declaration for successful transaction
        public event PaymentDel PaymentUnS; //event declaration for unseuccesful transaction
        private int creditCardNo;
        private string cardHolderName;
        private double balanceAmount;
        private double creditLimit;

        public CreditCard(int creditCardNo,string cardHolderName,double balanceAmount,double creditLimit)
        {
            this.creditCardNo = creditCardNo;
            this.cardHolderName = cardHolderName;
            this.balanceAmount = balanceAmount;
            this.creditLimit = creditLimit;
        }
        //business logic
        public void makePayment(double amount)
        {
            if (this.balanceAmount - amount >= 0)
            {
                this.balanceAmount -= amount;
                PaymentSuccess(amount);
            }
            else
            {
                PaymentUnS(amount);
            }
        }
        public double getBalance()
        {
            return balanceAmount;
        }

        public double getCreditLimit()
        {
            return this.creditLimit;
        }

        public int CreditCardNo
        {
            get
            {
                return creditCardNo;
            }
            set
            {
                this.creditCardNo = value;
            }
        }

        public string CardHolderName
        {
            get
            {
                return cardHolderName;
            }
            set
            {
                this.cardHolderName = value;
            }
        }

        public double BalanceAmount
        {
           
            set
            {
                this.balanceAmount = value;
            }
        }

        public double CreditLimit
        {
           
            set
            {
                creditLimit = value;
            }
        }

    }
}
