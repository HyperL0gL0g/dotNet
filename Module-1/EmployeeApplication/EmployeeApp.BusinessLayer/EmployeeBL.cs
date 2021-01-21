using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.Entites;
using EmployeeApp.DataAccessLayer;
using EmployeeApp.Exceptions;

namespace EmployeeApp.BusinessLayer
{
    public class EmployeeBL
    {
      //  - ValidateEmployee(Employee objEmployee)
           //     - AddEmployeeBL(Employee objEmployee)
            //    - UpdateEmployeeBL(Employee objEmployee)
            //    - SearchEmployeeBL(int employeeId)
            //    - DeleteEmployeeBL(int employeeId)
            //    - GetAllEmployeesBL()

        private static bool ValidateEmployee(Employee objEmployee)
        {
            bool validEmployee = true;
            StringBuilder message = new StringBuilder();
            if (objEmployee.EmployeeId <= 0)
            {
                message.Append(Environment.NewLine + "Invalid EmployeeId");
                validEmployee = false;
            }
            if (objEmployee.DepartmentId <= 0)
            {
                message.Append(Environment.NewLine + "Invalid DepartmentId");
                validEmployee = false;
            }
            if(objEmployee.DesignationId <= 0)
            {
                message.Append(Environment.NewLine + "Invalid DesignationId");
                validEmployee = false;
            }
            if (objEmployee.EmployeeName == string.Empty)
            {
                message.Append(Environment.NewLine + "Invalid EmployeeName");
                validEmployee = false;
            }

            if (!validEmployee)
            {
                throw new EmployeeAppException(message.ToString());
            }
           
            return validEmployee;
        }

        public static bool AddEmployeeBL(Employee objEmployee)
        {
            bool employeeAdded = false;
            try
            {
                if (ValidateEmployee(objEmployee))
                {
                   employeeAdded = EmployeeDAL.AddEmployeeDAL(objEmployee);
                }
            }
            catch(EmployeeAppException)
            {
                throw;
            }
            catch(SystemException ex)
            {
                throw ex;
            }

            return employeeAdded;
        }
         
        public static bool UpdateEmployeeBL(Employee employee)
        {
            bool employeeUpdated=false;
            try
            {
                if (ValidateEmployee(employee))
                {
                    employeeUpdated = EmployeeDAL.UpdateEmployeeDAL(employee);
                }
            }
            catch (EmployeeAppException)
            {
                throw;
            }
            catch(SystemException ex)
            {
                throw ex;
            }
            return employeeUpdated;
        }

        public static Employee SearchEmployeeBL(int employeeId)
        {
            Employee employee;
            try
            {
                if (employeeId <= 0)
                    throw new EmployeeAppException("Invalid employeeId");
                employee = EmployeeDAL.SearchEmployeeDAL(employeeId);
            }
            catch (EmployeeAppException)
            {
                throw;
            }
            catch(SystemException ex)
            {
                throw ex;
            }

            return employee;
        }

        public static bool DeleteEmployeeBL(int employeeId)
        {
            bool employeeDeleted = false;
            try
            {
                if (employeeId < 0)
                    throw new EmployeeAppException("Invalid employeeId");
                employeeDeleted = EmployeeDAL.DeleteEmployeeDAL(employeeId);
            }
            catch (EmployeeAppException)
            {
                throw;
            }
            catch(SystemException ex)
            {
                throw ex;
            }
            return employeeDeleted;
        }

        public static Dictionary<int,Employee> GetAllEmployeeBL()
        {
            return EmployeeDAL.GetAllEmployeeListDAL();
        }
    }
}
