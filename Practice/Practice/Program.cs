
using System;

delegate void NumberChanger();
namespace Practice
{

    class Program
    {
       // static int num = 10;

        public static void AddNum()
        {
            Console.WriteLine("Add");
        }
        public static void MultNum()
        {
            Console.WriteLine("SUB");
        }
  
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            Console.WriteLine("Multicast");
            nc1 += nc2;
            nc1();
            Console.WriteLine(" NO Multicast");
            nc1 -= nc2;
            nc1();
           
      
            Console.ReadKey();
        }
    }
}