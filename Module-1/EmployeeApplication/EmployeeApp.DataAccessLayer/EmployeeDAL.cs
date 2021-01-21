using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.Entites;
using EmployeeApp.Exceptions;

namespace EmployeeApp.DataAccessLayer
{
    public class EmployeeDAL
    {
        // - AddEmployeeDAL(Employee objEmployee)
        //      - UpdateEmployeeDAL(Employee objEmployee)
        //     - SearchEmployeeDAL(int employeeId)
        //      - DeleteEmployeeDAL(int employeeId)
        //    - GetAllEmployeesDAL()
        private static Dictionary<int,Employee> employeeList = new Dictionary<int,Employee>();

        public static bool AddEmployeeDAL(Employee objEmployee)
        {
            bool employeeAdded = false;
            try
            {
                employeeList.Add(objEmployee.EmployeeId,objEmployee);
                employeeAdded = true;
            }
            catch(SystemException ex)
            {
                throw new EmployeeAppException(ex.Message);
            }

            return employeeAdded;
        }

        public static bool UpdateEmployeeDAL(Employee objEmployee)
        {
            bool employeeUpdated = false;
            try
            {
                employeeList[objEmployee.EmployeeId] = objEmployee;
                employeeUpdated = true;
            }
            catch(SystemException ex)
            {
                throw new EmployeeAppException(ex.Message);
            }
           
            return employeeUpdated;
        }

        public static Employee SearchEmployeeDAL(int employeeId)
        {
            Employee employeeSearched;

            try
            {
                employeeSearched = employeeList[employeeId];
            }
            catch(SystemException ex)
            {
                throw new EmployeeAppException(ex.Message);
            }
            return employeeSearched;

        }

        public static bool DeleteEmployeeDAL(int employeeId)
        {
            bool employeeDeleted = false;

            try
            {
                Employee employee = employeeList[employeeId];
                if (employee != null)
                {
                    employeeList.Remove(employeeId);
                    employeeDeleted = true;
                }
            }
            catch(SystemException ex)
            {
                throw new EmployeeAppException(ex.Message);
            }

            return employeeDeleted;
        }
        
        public static Dictionary<int,Employee> GetAllEmployeeListDAL()
        {
            return employeeList;
        }
        
    }
}
