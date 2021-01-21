using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Entites
{
    public class Employee
    {
        private int employeeId;
        private string employeeName;
        private int designationId;
        private int departmentId;

        public Employee()
        {
            this.employeeId = 0;
            this.employeeName = string.Empty;
            this.designationId = 0;
            this.departmentId = 0;
        }

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                this.employeeId = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                this.employeeName = value;
            }
        }

        public int DesignationId
        {
            get
            {
                return designationId;
            }
            set
            {
                this.designationId = value;
            }
        }

        public int DepartmentId
        {
            get
            {
                return departmentId;
            }
            set
            {
                this.departmentId = value;
            }
        }
    }
}
