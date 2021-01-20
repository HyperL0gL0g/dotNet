using System;
// use a 1D array to store names of cities and then print them
namespace Lab2_Ques3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cities ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] city = new string[n];
            Console.WriteLine("Enter name of the cities");
            for(int i=0;i<n;i++)
            {
                city[i] = Console.ReadLine();
            }

            Console.WriteLine("Name of the  cities are");
            foreach (string i in city)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
