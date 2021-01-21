using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(fibonnaci(1, 1, 10, 2));
            //Console.WriteLine(factorial(3));
            // Console.WriteLine(reverese("Abhi"));
            // authentication();
            prog5();
            Console.ReadKey();
        }

        static void authentication()
        {
            string userName = "Abhi", passWord = "1111";
            int i = 0;
            bool loggedIn = false;
            while (i++ < 5)
            {
                Console.WriteLine("Enter UserName");
                string user = Console.ReadLine();
                Console.WriteLine("Enter password");
                string pass = Console.ReadLine();
                if (user.Equals(userName) && pass.Equals(passWord))
                {
                    loggedIn = true;
                    break;
                }
                Console.WriteLine("Enter correct Username and password");
            }
            if (loggedIn)
            {
                Console.WriteLine("Logged in successfully");
            }
            else
            {
                Console.WriteLine("Rejected");
            }


        }
        static string reverese(string str)
        {
            if (str.Length == 1)
                return str;
            return reverese(str.Substring(1)) + str[0];
        }
        static int factorial(int num)
        {
            int fact = 1;
            while (num > 1)
            {
                fact *= num;
                --num;
            }
            return fact;
        }
        static int fibonnaci(int num1, int num2, int n, int count)
        {
            if (count == n)
                return num2;
            return fibonnaci(num2, num1 + num2, n ,count + 1);
        }
    }
}
