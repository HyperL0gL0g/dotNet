using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.BusinessLayer;
using EmployeeApp.Entites;
using EmployeeApp.Exceptions;

namespace EmployeeApp.PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            char cont;
            do
            {
                PrintMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        UpdateEmployee();
                        break;
                    case 3:
                        SearchEmployee();
                        break;
                    case 4:
                        DeleteEmployee();
                        break;
                    case 5:
                        GetAllEmployee();
                        break;
                    case 6:
                        PrintMenu();
                        break;
                    default:
                        Console.WriteLine("Enter proper option");
                        break;
                }
                Console.WriteLine("Want to Continue? y/n");
                cont = Convert.ToChar(Console.ReadLine());
            } while (cont=='y');
        }

        public static void AddEmployee()
        {
            Employee employeeNew = new Employee();
            Console.WriteLine("Enter employee Id");
            employeeNew.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            employeeNew.EmployeeName =Console.ReadLine();
            Console.WriteLine("Enter designation Id");
            employeeNew.DesignationId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter department Id");
            employeeNew.DepartmentId = Convert.ToInt32(Console.ReadLine());

            try
            {
                bool success = EmployeeBL.AddEmployeeBL(employeeNew);
                if (success)
                {
                    Console.WriteLine("Employee successfully added");
                }
                else
                {
                    Console.WriteLine("Employee addition unsuccessful");
                }
            }
            catch(EmployeeAppException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void UpdateEmployee()
        {
            
            Console.WriteLine("Enter the employee id of employee you wanna update");
            int employeeId = Convert.ToInt32(Console.ReadLine());
           

            try
            {
                Employee employee = EmployeeBL.SearchEmployeeBL(employeeId);
                if (employee == null)
                {
                    Console.WriteLine("employeeId doesn't exits");
                    return;
                }
                Employee employeeNew = new Employee();
                employeeNew.EmployeeId = employeeId;

                Console.WriteLine("Enter updated employee name");
                employeeNew.EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter updated designation Id");
                employeeNew.DesignationId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter updated department Id");
                employeeNew.DepartmentId = Convert.ToInt32(Console.ReadLine());
                bool success = EmployeeBL.UpdateEmployeeBL(employeeNew);
                if (success)
                    Console.WriteLine("Employee successfully updated");
                else
                    Console.WriteLine("Employee updation unsuccessful");
            }
            catch(EmployeeAppException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SearchEmployee()
        {
            Console.WriteLine("Enter employee Id");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            try
            {
                Employee employee = EmployeeBL.SearchEmployeeBL(employeeId);
                if (employee != null)
                {
                    Console.WriteLine("Employee Details");
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("EmployeeID\t\tEmployeeName\t\tDesignationNo\t\tDepartmentNo");
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("{0}\t\t\t\t\t\t\t\t{1}\t\t\t\t\t\t\t\t{2}\t\t\t\t\t\t\t\t{3}", employee.EmployeeId, employee.EmployeeName, employee.DesignationId,employee.DepartmentId);
                    Console.WriteLine("******************************************************************************");
                }
                else
                {
                    Console.WriteLine("Employee doesn't exist");
                }
            }
            catch(EmployeeAppException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DeleteEmployee()
        {
            Console.WriteLine("Enter employee Id");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            try
            {
                bool success = EmployeeBL.DeleteEmployeeBL(employeeId);
                if (success)
                    Console.WriteLine("Employee successfully deleted");
                else
                    Console.WriteLine("Delete unsuccessful");
            }
            catch(EmployeeAppException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void GetAllEmployee()
        {
            try
            {
                Dictionary<int,Employee> employees = EmployeeBL.GetAllEmployeeBL();
                if (employees != null)
                {
                    Console.WriteLine("Employee Details");
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("EmployeeID\tEmployeeName\tDesignationNo\tDepartmentNo");
                    foreach (KeyValuePair<int, Employee> keyVal in employees)
                    {
                        Employee employee = keyVal.Value;
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", employee.EmployeeId, employee.EmployeeName, employee.DesignationId, employee.DepartmentId);
                        Console.WriteLine("******************************************************************************");
                    }
                }
                else
                {
                    Console.WriteLine("No employee Found");
                }
            }
            catch(EmployeeAppException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void PrintMenu()
        {
            Console.WriteLine("********************EmployeeApp Menu**************************");
            Console.WriteLine("1) Add Employee");
            Console.WriteLine("2) Update Employee");
            Console.WriteLine("3) Search Employee");
            Console.WriteLine("4) Delete Employee");
            Console.WriteLine("5) Get All Employees");
            Console.WriteLine("6) Print Menu");
            Console.WriteLine("0) Exit");
            Console.WriteLine("***************************************************************");
        }
    }
}
