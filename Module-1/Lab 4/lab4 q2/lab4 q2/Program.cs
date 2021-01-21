using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_q2
{
    class Program
    {
        //baasic debugging . Had to add virtual keyword to base and override keyword in derived class
        static void Main(string[] args)
        {
            Shape s;
            s = new Triangle();
            s.WhoamI();
            s = new Circle();
            s.WhoamI();
            Console.ReadKey();
        }
    }
}
