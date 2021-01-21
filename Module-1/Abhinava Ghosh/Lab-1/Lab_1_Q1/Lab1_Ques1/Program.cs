//Abhinava Ghosh 1705099
using System;
using EmployeeLib;

namespace Lab1_Ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // till the user enters 0 continue inputting values
            {
                Console.WriteLine("Enter number of Employees\n");
                int n = Int32.Parse(Console.ReadLine());

                Employee[] e = new Employee[n]; //array of objects

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter employee id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter employee name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter employee city");
                    string city = Console.ReadLine();

                    Console.WriteLine("Enter employee dept");
                    string dept = Console.ReadLine();

                    Console.WriteLine("Enter employee salary");
                    int salary = Convert.ToInt32(Console.ReadLine());


                    Employee objEmployee = new Employee(); //object creation
                    objEmployee.Add_Employee(id, name, city, dept, salary); //calling setter

                    e[i] = objEmployee; 
                }

                for (int i = 0; i < n; i++)  // printing
                {
                    e[i].Print_Employee();
                }

                // if user presses 0 then exit the application else continue with the process 
                Console.WriteLine("Please Enter 0 to exit the application , Enter 1 for more entries");
                int inp = Convert.ToInt32(Console.ReadLine());
                if (inp == 0)
                {
                    System.Environment.Exit(1);
                }
            }


        }
    } // class ends
}
