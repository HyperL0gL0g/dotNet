using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLib;
namespace ICICIApp
{
    class ICICI
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard(1,"Abhi",500,5);
            ICIC_BL iCIC_BL = new ICIC_BL();

            creditCard.PaymentSuccess += new PaymentDel(iCIC_BL.payamentSuc);
            creditCard.PaymentUnS += new PaymentDel(iCIC_BL.PaymentUN);

            creditCard.makePayment(450);//succes
            creditCard.makePayment(100);//failed
            Console.ReadLine();
        }
    }

    class ICIC_BL
    {
        public void payamentSuc(double amount)
        {
            Console.WriteLine("Amount " + amount + " Payment successful");
        }

        public void PaymentUN(double amount)
        {
            Console.WriteLine("Amount " + amount + " Payment not successful");
        }
    }
}
