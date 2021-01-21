using System;
//program to find the square or cube of a number 
namespace Lab2_Ques_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Square_Cube ob1 = new Square_Cube();
                operations ob2 = new operations();
                Console.WriteLine("Enter the number");
                ob1.number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1 to find Square of a number and 2 to find Cube of a number");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        int x;
                        x = ob2.Square(ob1.number);
                        Console.WriteLine("Square of the number is {0}", x);
                        break;

                    case 2:
                        int y;
                        y = ob2.Cube(ob1.number);
                        Console.WriteLine("Cube of the number is {0}", y);
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;


                }
                Console.WriteLine("Enter 0 to continue and press 1 to exit application");
                int choice  = Convert.ToInt32(Console.ReadLine());
                if(choice==1)
                {
                    break;
                }

            }

        }
    }
}
