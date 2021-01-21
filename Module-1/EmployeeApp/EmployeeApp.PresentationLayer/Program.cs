using System;
using System.Collections.Generic;
using System.Text;
using EmployeeApp.Entities;
using EmployeeApp.BusinessLayer;
using EmployeeApp.Exceptions;

namespace EmployeeApp.PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ListAllEmployees();
                        break;
                    case 3:
                        SearchEmployeeByID();
                        break;
                    case 4:
                        UpdateEmployee();
                        break;
                    case 5:
                        DeleteEmployee();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != -1);
        }

        private static void DeleteEmployee()
        {
            try
            {
                int deleteEmployeeID;
                Console.WriteLine("Enter EmployeeID to Delete:");
                deleteEmployeeID = Convert.ToInt32(Console.ReadLine());
                Employee deleteEmployee = EmployeeBL.SearchEmployeeBL(deleteEmployeeID);
                if (deleteEmployee != null)
                {
                    bool employeedeleted = EmployeeBL.DeleteEmployeeBL(deleteEmployeeID);
                    if (employeedeleted)
                        Console.WriteLine("Employee Deleted");
                    else
                        Console.WriteLine("Employee not Deleted ");     
                }
                else
                {
                    Console.WriteLine("No Employee Details Available");
                }


            }
            catch (EmployeePhoneBookException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void UpdateEmployee()
        {
            try
            {
                int updateEmployeeID;
                Console.WriteLine("Enter EmployeeID to Update Details:");
                updateEmployeeID = Convert.ToInt32(Console.ReadLine());
                Employee updatedEmployee = EmployeeBL.SearchEmployeeBL(updateEmployeeID);
                if (updatedEmployee != null)
                {
                    Console.WriteLine("Update Employee Name :");
                    updatedEmployee.EmployeeName = Console.ReadLine();
                    Console.WriteLine("Update PhoneNumber :");
                    updatedEmployee.EmployeeContactNumber = Console.ReadLine();
                    bool employeeUpdated = EmployeeBL.UpdateEmployeeBL(updatedEmployee);
                    if (employeeUpdated)
                        Console.WriteLine("Employee Details Updated");
                    else
                        Console.WriteLine("Employee Details not Updated ");
                }
                else
                {
                    Console.WriteLine("No Employee Details Available");
                }
               

            }
            catch (EmployeePhoneBookException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SearchEmployeeByID()
        {
            try
            {
                int searchEmployeeID;
                Console.WriteLine("Enter EmployeeID to Search:");
                searchEmployeeID = Convert.ToInt32(Console.ReadLine());
                Employee searchEmployee = EmployeeBL.SearchEmployeeBL(searchEmployeeID);
                if (searchEmployee != null)
                {
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("EmployeeID\t\tName\t\tPhoneNumber");
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", searchEmployee.EmployeeID, searchEmployee.EmployeeName, searchEmployee.EmployeeContactNumber);
                    Console.WriteLine("******************************************************************************");
                }
                else
                {
                    Console.WriteLine("No Employee Details Available");
                }

            }
            catch (EmployeePhoneBookException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void ListAllEmployees()
        {
            try
            {
                List<Employee> employeeList = EmployeeBL.GetAllEmployeesBL();
                if (employeeList != null)
                {
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("EmployeeID\t\tName\t\tPhoneNumber");
                    Console.WriteLine("******************************************************************************");
                    foreach (Employee employee in employeeList)
                    {
                        Console.WriteLine("{0}\t\t{1}\t\t{2}", employee.EmployeeID, employee.EmployeeName, employee.EmployeeContactNumber);
                    }
                    Console.WriteLine("******************************************************************************");

                }
                else
                {
                    Console.WriteLine("No Employee Details Available");
                }
            }
            catch (EmployeePhoneBookException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddEmployee()
        {
            try
            {
                Employee newEmployee = new Employee();
                Console.WriteLine("Enter EmployeeID :");
                newEmployee.EmployeeID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name :");
                newEmployee.EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber :");
                newEmployee.EmployeeContactNumber = Console.ReadLine();
                bool employeeAdded = EmployeeBL.AddEmployeeBL(newEmployee);
                if (employeeAdded)
                    Console.WriteLine("Employee Added");
                else
                    Console.WriteLine("Employee not Added");
            }
            catch (EmployeePhoneBookException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("\n***********Employee PhoneBook Menu***********");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. List All Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Exit");
            Console.WriteLine("******************************************\n");

        }
    }
}
