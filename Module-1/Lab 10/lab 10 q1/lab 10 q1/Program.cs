using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//delegate practice
// basic maths operations using delegates
namespace lab_10_q1
{
    class Program
    {
        delegate double Mathoperation(double n1, double n2); // delegate declaration
        static void Main(string[] args)
        {
            char temp;
            do
            {
                int op;
                double n1, n2, res;
                ArthematicOperation objA = new ArthematicOperation(); // object creation
                Console.WriteLine("Enter the first number");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1-Addition \n2-Subtraction \n3-Multiplication \n4-Division \n5-Max number");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Mathoperation objMA = new Mathoperation(objA.Add); // creating object of delegate & passing class object as parameter
                      //  res = objMA(n1, n2); //passing values via delegate object
                        res = objMA.Invoke(n1, n2); // 2nd method
                        Console.WriteLine("The sum is:" + res);
                        break;

                    case 2:
                        Mathoperation objMS = new Mathoperation(objA.Sub); //sub
                        res = objMS(n1, n2);
                        Console.WriteLine("The difference is:" + res);
                        break;

                    case 3:
                        Mathoperation objMM = new Mathoperation(objA.Mul); // mul
                        res = objMM(n1, n2);
                        Console.WriteLine("The product is:" + res);
                        break;

                    case 4:
                        Mathoperation objMD = new Mathoperation(objA.Div); // div
                        res = objMD(n1, n2);
                        Console.WriteLine("The result of division is:" + res);
                        break;

                    case 5:
                        Mathoperation objMMa = new Mathoperation(objA.Max); // max
                        res = objMMa(n1, n2);
                        Console.WriteLine("The maximum number is:" + res);
                        break;

                    default:
                        Console.WriteLine("Enter a valid option");
                        break;

                }
                Console.WriteLine("Enter y to continue ");
                temp= Convert.ToChar(Console.ReadLine());
            } while (temp == 'y');
        }
    }
}
