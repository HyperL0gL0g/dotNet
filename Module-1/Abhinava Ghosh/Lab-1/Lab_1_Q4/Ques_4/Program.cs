using System;
//enter and display student details
namespace Ques_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Students ob = new Students();
           

            Console.WriteLine("Enter roll number");
            ob.roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            ob.name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter age");
            ob.age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter your gender(M/F)");
            ob.gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter your D.O.B(DD/MM/YYYY)");
            ob.dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter address");
            ob.address = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter  Percentage");
            ob.percentage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("------"+ob.name+"'s "+"Record------");

            Console.WriteLine("Roll no.-{0}, Name- {1}, Age- {2}, Gender- {3}, D.O.B- {4}, address- {5}, percentage- {6}", ob.roll, ob.name, ob.age, ob.gender, ob.dob, ob.address, ob.percentage);
        }
    }
}
