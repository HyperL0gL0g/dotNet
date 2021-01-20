using System;
using CalculatorLib;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- ABHINAV'S CALCULATOR -----");
            char flag;
            do
            {
                int operation;
                int firstNo;
                int secondNo;
                int result;
                Console.WriteLine("Press 1 for Addition(+), 2 for Subtraction(-), 3 for Multiplication(*), 4 for Division(/), 5 for Modulus(%) and 6 to Exit.");
                operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 6)
                {
                    return;
                }
                Console.WriteLine("Enter First Number");
                firstNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                secondNo = Convert.ToInt32(Console.ReadLine());
                Calculator objCalculator = new Calculator();
                switch (operation)
                {
                    case 1:
                        //Addition
                        result = objCalculator.Addition(firstNo, secondNo);
                        Console.WriteLine("Addition of two numbers is: " + result);
                        break;
                    case 2:
                        //Subtraction
                        result = objCalculator.Subtraction(firstNo, secondNo);
                        Console.WriteLine("Subtraction of two numbers is: " + result);
                        break;
                    case 3:
                        //Multiplication
                        result = objCalculator.Multiplication(firstNo, secondNo);
                        Console.WriteLine("Multiplicaiton of two numbers is: " + result);
                        break;
                    case 4:
                        //Division
                        result = objCalculator.Division(firstNo, secondNo);
                        Console.WriteLine("Division of two numbers is: " + result);
                        break;
                    case 5:
                        //Modulus
                        result = objCalculator.Modulus(firstNo, secondNo);
                        Console.WriteLine("Division of two numbers is: " + result);
                        break;

                    default:
                        //Default logic
                        Console.WriteLine("Please enter correct option.");
                        break;
                }
                Console.WriteLine("Do you want to continue. Press 'Y' to continue or 'N' to exit.");
                flag = Convert.ToChar(Console.ReadLine());
            } while (flag == 'Y');

            Console.ReadLine();

        }
       
    }
}
