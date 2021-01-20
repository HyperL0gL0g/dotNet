using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Entities
{
    public class Employee
    {
        private int employeeID;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
       private int departmentID;

        public int DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }

        public Employee()
        {
            employeeID = 0;
            employeeName = string.Empty;
            
        }
    }
}
