using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_q1
{
    class ContractE:Employ // inheritance
    {
        //derived class
        public int sal;
        internal override void GetSalary()
        {
            int perks;
            //additional field
            Console.WriteLine("Enter the perks:");
            perks = Convert.ToInt32(Console.ReadLine());
            sal = Salary + perks;
            Console.WriteLine("The salary is:" + sal);
        }
    }
}
