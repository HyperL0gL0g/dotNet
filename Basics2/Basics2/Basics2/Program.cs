using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics2
{
    class Program
    {
        static void Main(string[] args)
        {
            //question1();
            //multiplicationTable(6);
            //question3(25);

            //question4(30);

            //question5("Abhi", 1);
            // questions6("Abhi");
            // Console.WriteLine(question7(-1, 1));

            //question8("Abhinava Ghosh");

            //Console.WriteLine(question9());
            Console.WriteLine(sumDigits(1221));
            Console.ReadKey();
        }

    
        static int sumDigits(int num)
        {
            if (num == 0)
                return 0;
            return (num % 10) + sumDigits(num / 10);
        }
       
        static int question9()
        {
            int i = 2, pC = 0, sum = 0;

            while (pC < 500)
            {
                if (isPrime(i))
                {
                    sum += i;
                    ++pC;
                }
                ++i;
            }
            return sum;
        }

        static bool isPrime(int n)
        {
            if (n == 1 || n == 2)
                return true;

            for(int i = 2; i <= Math.Sqrt(n); ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void question8(string str)
        {
            string[] arr = str.Split(' ');
            string max = "";
            foreach (string s in arr)
            {
                if (max.Length < s.Length)
                    max = s;
            }
            Console.WriteLine(max);
        }
        static bool question7(int num1,int num2)
        {
            return num1 < 0 && num2 >= 0;
        }
        static void questions6(string str)
        {
      
            char[] arr = str.ToArray<char>();
            char temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;
           
            Console.WriteLine(arr);
        }
        static void question5(string str,int i)
        {
            str = str.Remove(i, 1);
            Console.WriteLine(str);
        }
        static void question4(int n)
        {
            Console.WriteLine("Fahrenheit "+ ((n * 9 / 5) + 32));
            Console.WriteLine("Kelvin " + (n + 273.15));
        }
        static void question3(int n)
        {
            for(int i = 0; i < 2; ++i)
            {
                Console.WriteLine(n + " " + n + " " + n + " " + n);
                Console.WriteLine(n + "" + n + "" + n + "" + n);
            }
        }
        static void question1()
        {
            // -1 + 4 * 6
            //  (35 + 5) % 7
            //   14 + -4 * 6 / 11
            //  2 + 15 / 6 * 1 - 7 % 2

            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        static void multiplicationTable(int n)
        {
            for(int i = 1; i <= 10; ++i)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
        }
    }
}
