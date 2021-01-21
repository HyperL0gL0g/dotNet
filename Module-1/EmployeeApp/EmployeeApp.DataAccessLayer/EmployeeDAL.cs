using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using EmployeePhoneBook.Entities;
using EmployeePhoneBook.Exceptions;

namespace EmployeePhoneBook.DataAccessLayer
{
    public class EmployeeDAL
    {
        public static List<Employee> emplpoyeeList = new List<Employee>();

        public bool AddEmployeetDAL(Employee newEmployee)
        {
            bool employeeAdded = false;
            try
            {
                employeeList.Add(newEmployee);
                employeeAdded = true;
            }
            catch (SystemException ex)
            {
                throw new EmployeePhoneBookException(ex.Message);
            }
            return employeeAdded;

        }

        public List<Employee> GetAllEmployeesDAL()
        {
            return employeeList;
        }

        public Employee SearchEmployeeDAL(int searchEmployeeID)
        {
            Employee searchEmployee = null;
            try
            {
                searchEmployee = employeeList.Find(employee => employee.EmployeeID == searchEmployeeID);
            }
            catch (SystemException ex)
            {
                throw new EmployeePhoneBookException(ex.Message);
            }
            return searchEmployee;
        }

        public bool UpdateEmployeeDAL(Employee updateEmployee)
        {
            bool employeeUpdated = false;
            try
            {
                for (int i = 0; i < employeeList.Count; i++)
                {
                    if (employeeList[i].EmployeeID == updateEmployee.EmployeeID)
                    {
                        updateEmployee.EmployeeName = employeeList[i].EmployeeName;
                        updateEmployee.EmployeeContactNumber = employeeList[i].EmployeeContactNumber;
                        employeeUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new EmployeePhoneBookException(ex.Message);
            }
            return employeeUpdated;

        }

        public bool DeleteEmployeeDAL(int deleteEmployeeID)
        {
            bool employeeDeleted = false;
            try
            {
                Employee deleteEmployee = employeeList.Find(employee => employee.EmployeeID == deleteEmployeeID);

                if (deleteEmployee != null)
                {
                    employeeList.Remove(deleteEmployee);
                    employeeDeleted = true;
                }
            }
            catch (DbException ex)
            {
                throw new EmployeePhoneBookException(ex.Message);
            }
            return employeeDeleted;

        }

    }
}
