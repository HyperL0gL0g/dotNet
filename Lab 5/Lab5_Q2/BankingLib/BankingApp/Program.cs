using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingLib;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI iCICIObj1 = new ICICI();
            iCICIObj1.AccountType = BankAccountTypeEnum.Saving;
            iCICIObj1.deposite(50000);

            ICICI iCICIObj2 = new ICICI();
            iCICIObj2.AccountType = BankAccountTypeEnum.Current;
            iCICIObj2.deposite(20000);

            Console.WriteLine("Saving account of ICICI " +iCICIObj1.getBalance());
            Console.WriteLine("Current account of ICICI "+iCICIObj2.getBalance());

            iCICIObj1.transfer(iCICIObj2, 5000);

            Console.WriteLine();

            Console.WriteLine("Saving account of ICICI " + iCICIObj1.getBalance());
            Console.WriteLine("Current account of ICICI " + iCICIObj2.getBalance());

            Console.WriteLine();

            HSBC hSBCObj1 = new HSBC();
            hSBCObj1.AccountType = BankAccountTypeEnum.Saving;
            hSBCObj1.deposite(50000);

            HSBC hSBCObj2 = new HSBC();
            hSBCObj2.AccountType = BankAccountTypeEnum.Current;
            hSBCObj2.deposite(20000);

            Console.WriteLine("Saving account of HSBC " + hSBCObj1.getBalance());
            Console.WriteLine("Current account of HSBC " + hSBCObj2.getBalance());

            hSBCObj1.transfer(hSBCObj2, 30000);

            Console.WriteLine();

            Console.WriteLine("Saving account of HSBC " + hSBCObj1.getBalance());
            Console.WriteLine("Current account of HSBC " + hSBCObj2.getBalance());

            Console.WriteLine();

            iCICIObj1.calculateInterest();

            Console.WriteLine();
            hSBCObj1.calculateInterest();

            Console.ReadLine();

        }
    }
}
