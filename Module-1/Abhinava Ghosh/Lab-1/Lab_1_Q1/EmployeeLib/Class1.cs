//Abhinava Ghosh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    

   
        public class Employee
        {
            private int _empID;

            private string _empName;

            private string _city;

            private string dept;

            private int salary;

            public void Add_Employee(int _empID1, String _empName1, String _city1, string dept1, int salary1)
            {
                _empID = _empID1;
                _empName = _empName1;
                _city = _city1;
                dept = dept1;
                salary = salary1;
            }
            public void Print_Employee()
            {
            Console.WriteLine(" ");
            Console.WriteLine("ID= " + _empID);
            Console.WriteLine("NAME= " + _empName);
            Console.WriteLine("CITY= " + _city);
            Console.WriteLine("DEPARTMENT= " + dept);
            Console.WriteLine("SALARY= " +salary);
        }
        }
    

}
