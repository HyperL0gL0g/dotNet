using System;
//multidimension array
namespace Lab2_Ques5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] columns = { "Book Title", "Author", "Publisher", "Price" };
            string[,] bookDetails = new string [2, 4];
            bookDetails[0, 0] = "Book Title";
            bookDetails[0, 1] = "Author";
            bookDetails[0, 2] = "Publisher";
            bookDetails[0, 3] = "Price";

            Console.WriteLine("Enter book details -  Title , Author , Publisher , Price (Please maintain the order)");

            for(int i=0;i<4;i++)
            {

                bookDetails[1, i] = Console.ReadLine();
            }

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<4;j++)
                {
                    Console.Write("{0}          ",bookDetails[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
}
