using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Employee
    {
        private int employeeNo;
        private string employeeName;
        private double basicSalary;
        private double providentFund;


        public Employee()
        {
            this.employeeNo = 0;
            this.employeeName = "XYZ";
            this.basicSalary = 0;
            this.providentFund = 0;
        }
        public Employee(int employeeNo,string employeeName,double basicSalary,double providentFund)
        {
            this.employeeNo = employeeNo;
            this.employeeName = employeeName;
            this.basicSalary = basicSalary;
            this.providentFund = providentFund;
        }

        public int EmployeeNo
        {
            get
            {
                return this.employeeNo;
            }
            set
            {
                this.employeeNo = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return this.employeeName;
            }
            set
            {
                this.employeeName = value;
            }
        }

        public double BasicSalary
        {
            get
            {
                return this.basicSalary;
            }
            set
            {
                this.basicSalary = value;
            }
        }

        public double ProvidentFund
        {
            get
            {
                return this.providentFund;
            }
            set
            {
                this.providentFund = value;
            }
        }

    }
}
