using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_q2
{
    public class Circle :  Shape
    {
       internal override void WhoamI() //override keyword was missing
        {
           Console.WriteLine("I m Circle");
        }
    }
}
