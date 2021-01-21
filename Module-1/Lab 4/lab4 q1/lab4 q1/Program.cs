using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            char temp;
            do
            {
                Employ objE = new PermanentE(); //permanent employee
                Employ objC = new ContractE();  //contract employee
                //accept user data
                Console.WriteLine("Enter the employee id:");
                objE.employeeID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the employee name:");
                objE.employeeName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the address:");
                objE.Address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the city:");
                objE.City = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the department:");
                objE.Department = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the salary:");
                objE.Salary = Convert.ToInt32(Console.ReadLine());
                objC.Salary = objE.Salary; //initially both are same but later on some changes will be there

                Console.WriteLine("Enter 1 if the employee is a contract employee \nEnter 2 if the employee is a permanent employee");
                op = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("The Employee detail is :");
                Console.WriteLine("employee id:" + objE.employeeID);
                Console.WriteLine("employee name:" + objE.employeeName);
                Console.WriteLine("address:" + objE.Address);
                Console.WriteLine("city:" + objE.City);
                Console.WriteLine("department:" + objE.Department);

                switch (op)
                {
                    case 1:
                        objE.GetSalary();
                        break;
                    case 2:
                        objC.GetSalary();
                        break;
                    default:
                        Console.WriteLine("Enter the correct option :");
                        break;
                }
                Console.WriteLine("Enter y to input another details:");
                temp = Convert.ToChar(Console.ReadLine());
            } while (temp == 'y');
            
        }
    }
}
