using System;

namespace Lab2_Ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 30 values");
                int[,] a = new int[5, 6];
                 // 5 rows 6 columns

                for (int i = 0; i < 5; i++)  // rows
                {
                    for (int j = 0; j < 6; j++) // columns
                    {
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < 5; i++)
                {

                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                    }
                }
                Console.WriteLine("press 0 to exit , and 1 to continue");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 0)
                    break;


            }
        }
    }
}