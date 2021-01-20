using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_q2
{
    //find if the bird can fly at a particuler height.
    class Program
    {
        static void Main(string[] args)
        {
            Bird objb = new Bird("Crow" , double.Parse("200")); // putting our own max height
            objb.fly();
            objb.fly(double.Parse("201")); //current height of bird
        }
    }
}
