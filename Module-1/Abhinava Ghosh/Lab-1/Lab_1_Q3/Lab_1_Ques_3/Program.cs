using System;
namespace Lab_1_Ques_3
    {
        class Program
        {
            static void Main(string[] args)
        {
                

                int X = Convert.ToInt32(args[0]);

                switch (X)
                {
                    case 1:
                        Console.WriteLine("Number entered is 1");
                        break;
                    case 2:
                        Console.WriteLine("Number entered is 2");
                        break;
                    case 3:
                        Console.WriteLine("Number entered is 3");
                        break;
                    case 4:
                        Console.WriteLine("Number entered is 4");
                        break;
                    case 5:
                        Console.WriteLine("Number entered is 5");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;

                }
            }
        }
    }


    

