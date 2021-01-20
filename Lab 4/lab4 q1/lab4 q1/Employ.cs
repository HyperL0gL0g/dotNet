using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//derive two classes from employee class and add some aditional fields to some of them.
namespace lab4_q1
{
    abstract class Employ
    {
        //base class
        private int EmployeeID;
        private string EmployeeName;
        private string address;
        private string city;
        private string department;
        public int Salary;

        //setters and getters

        public int employeeID
        {
            get
            {
                return EmployeeID;
            }
            set
            {
                EmployeeID = value;
            }
        }
        public string employeeName
        {
            get
            {
                return EmployeeName;
            }
            set
            {
                EmployeeName = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
      


        internal abstract void GetSalary();


    }
}
