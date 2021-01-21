using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_q1
{
    class PermanentE:Employ
    {
        //derived class

        public double sal1;
        internal override void GetSalary()
        {
            int providentfund; //extra field to be added
            Console.WriteLine("Enter the provident fund:");
            providentfund = Convert.ToInt32(Console.ReadLine());
           sal1 = Salary - providentfund; //final salary
            int leaves;
            Console.WriteLine("Enter the number of leaves:");
            leaves  =  Convert.ToInt32(Console.ReadLine()); 
           
            Console.WriteLine("The salary is:" + sal1);
        }
    }
}
