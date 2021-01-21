using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePhoneBook.Entities;
using EmployeePhoneBook.Exceptions;
using EmployeePhoneBook.DataAccessLayer;

namespace EmployeePhoneBook.BusinessLayer
{
    public class EmployeeBL
    {
        private static bool ValidateEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();
            bool validEmployee = true;
            if (employee.EmployeeID <= 0)
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Invalid Employee ID");

            }
            if (employee.EmployeeName == string.Empty)
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Employee Name Required");

            }
            if (employee.EmployeeContactNumber.Length < 10)
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Required 10 Digit Contact Number");
            }
            if (validEmployee == false)
                throw new EmployeePhoneBookException(sb.ToString());
            return validEmployee;
        }

        public static bool AddEmployeeBL(Employee newEmployee)
        {
            bool employeeAdded = false;
            try
            {
                if (ValidateEmployee(newEmployee))
                {
                    EmployeeDAL employeeDAL = new EmployeeDAL();
                    employeeAdded = employeeDAL.AddEmployeeDAL(newEmployee);
                }
            }
            catch (EmployeePhoneBookException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employeeAdded;
        }

        public static List<Employee> GetAllEmployeesBL()
        {
            List<Employee> employeeList = null;
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();
                employeeList = employeeDAL.GetAllEmployeesDAL();
            }
            catch (EmployeePhoneBookException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employeeList;
        }

        public static Employee SearchEmployeeBL(int searchEmployeeID)
        {
            Employee searchEmployee = null;
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();
                searchEmployee = employeeDAL.SearchEmployeeDAL(searchEmployeeID);
            }
            catch (EmployeePhoneBookException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchEmployee;

        }

        public static bool UpdateEmployeeBL(Employee updateEmployee)
        {
            bool employeeUpdated = false;
            try
            {
                if (ValidateEmployee(updateEmployee))
                {
                    EmployeeDAL employeeDAL = new EmployeeDAL();
                    employeeUpdated = employeeDAL.UpdateEmployeeDAL(updateEmployee);
                }
            }
            catch (EmployeePhoneBookException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employeeUpdated;
        }

        public static bool DeleteEmployeeBL(int deleteEmployeeID)
        {
            bool employeeDeleted = false;
            try
            {
                if (deleteEmployeeID > 0)
                {
                    EmployeeDAL employeeDAL = new EmployeeDAL();
                    employeeDeleted = employeeDAL.DeleteEmployeeDAL(deleteEmployeeID);
                }
                else
                {
                    throw new EmployeePhoneBookException("Invalid Employee ID");
                }
            }
            catch (EmployeePhoneBookException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employeeDeleted;
        }
       
    }
}
