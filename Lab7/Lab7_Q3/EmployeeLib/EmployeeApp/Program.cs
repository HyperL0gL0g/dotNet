using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace EmployeeApp
{
    class Program
    {
        static List<Employee> employeeList = new List<Employee>();

        static void addEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }

        static Employee search(int employeeId)
        {
            foreach(Employee employee in employeeList)
            {
                if(employee.EmployeeNo == employeeId)
                {
                    Console.WriteLine("Employee details are:");
                    Console.WriteLine("EmployeeNo: " + employee.EmployeeNo);
                    Console.WriteLine("EmployeeName: " + employee.EmployeeName);
                    Console.WriteLine("Basic Salary: " + employee.BasicSalary);
                    Console.WriteLine("Provident Fund: " + employee.ProvidentFund);
                    return employee;
                }
            }
            Console.WriteLine("Employee id doesn't exist");
            return null;
        }

        static void delete(int employeeId)
        {
            Employee employee1=null;
            foreach (Employee employee in employeeList)
            {
                if (employee.EmployeeNo == employeeId)
                {
                    employee1 = employee;
                }
            }
            if(employee1!=null)
             employeeList.Remove(employee1);
            
        }

        static void showAll()
        {
            foreach (Employee employee in employeeList)
            {
            
            Console.WriteLine("\n Employee details are:");
            Console.WriteLine("EmployeeNo: " + employee.EmployeeNo);
            Console.WriteLine("EmployeeName: " + employee.EmployeeName);
            Console.WriteLine("Basic Salary: " + employee.BasicSalary);
            Console.WriteLine("Provident Fund: " + employee.ProvidentFund);

            }
        }

        static void Main(string[] args)
        {
            int choice;
            char cont;
            do
            {
                Console.WriteLine("choose 1)Add Employee 2)search employee record 3)Delete EmployeeRecord 4)View all Employee record 0)exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0: 
                        return;
                    case 1:
                        Console.WriteLine("Enter employee details");
                        Console.WriteLine("Enter Employee id");
                        int employeeId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Employee name");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter basic salary");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Provident Fund");
                        double fund = Convert.ToDouble(Console.ReadLine());
                        addEmployee(new Employee(employeeId,name,salary,fund));
                        break;
                    case 2:
                        Console.WriteLine("Enter the employee id for searching");
                        int employeeId1 = Convert.ToInt32(Console.ReadLine());
                        search(employeeId1);
                        break;
                    case 3:
                        Console.WriteLine("Enter the employee id for delete");
                        int employeeId2 = Convert.ToInt32(Console.ReadLine());
                        delete(employeeId2);
                        break;
                    case 4:
                        showAll();
                        break;
                    default:
                        Console.WriteLine("Enter proper option");
                        break;
                }
                Console.WriteLine("Want to  continue? y/n");
                cont = char.Parse(Console.ReadLine());
            } while (cont=='y');
        }
    }
}
