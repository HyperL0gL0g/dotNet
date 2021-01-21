using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//static addition
namespace lab_10_q2
{
    class Program
    {
        delegate double Mathoperation(double n1, double n2);
        static void Main(string[] args)
        {
            char temp;
            do
            {
                int op;
                double n1, n2;
                ArthematicOperation objA = new ArthematicOperation();
                Console.WriteLine("Enter the first number");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the secondde number");
                n2 = Convert.ToDouble(Console.ReadLine());

                

                Console.WriteLine("1-Addition \n2-Substraction \n3-Multiplication \n4-Devision \n5-Maximum number");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        PerformArithmeticOperation(n1, n2, objA.Add);
                        break;

                    case 2:
                        PerformArithmeticOperation(n1, n2, objA.Sub);
                        break;

                    case 3:
                        PerformArithmeticOperation(n1, n2, objA.Mul);
                        break;

                    case 4:
                        PerformArithmeticOperation(n1, n2, objA.Div);
                        break;

                    case 5:
                        PerformArithmeticOperation(n1, n2, objA.Max);
                        break;

                    default:
                        Console.WriteLine("Enter a valid option");
                        break;

                }
                Console.WriteLine("Enter y to enter again");
                temp = Convert.ToChar(Console.ReadLine());
            } while (temp == 'y');
        }


        static void PerformArithmeticOperation(double num1, double num2, Mathoperation arOperation)
        {
            Mathoperation objMA = new Mathoperation(arOperation);
            double res = objMA(num1, num2);
            Console.WriteLine("The result is:" + res);
        }
    }
    
}
