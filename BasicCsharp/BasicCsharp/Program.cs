using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharp
{
    class Program : Abs
    {
        static void Main(string[] args)
        {
            int i = 0;
            try
            {
                int a = 10 / i;
            }
            catch(Exception e )
            {
                Console.WriteLine("divide by zero");
            }
            finally
            {
                Console.WriteLine("finallly");
            }
            /* int a = 10;
             double b = 10.0;
             string s = "sadfsd";
             bool c = false;
             float d = 10.1f; // use f suffix
             long e = 1000000;
             //arrays
             int[] arr = new int[3];
             int[] arr2 = { 1, 3, 4 };
             int[] arr3 = new int[] { 1, 2, 3, 3 };
             //2d arrays
             int[,] arr4 = new int[2, 1];
             //jagged arrays
             int[][] jag = new int[2][];
             jag[0] = new int[3];
             jag[1] = new int[4];
             // nullable
             int? n = null;
             //Console.WriteLine(n);
            // Console.ReadLine();
             //var
             var v = 10;
             var g = "cas";

             //dynamic
             dynamic dy;
             dy = 112;
             dy = false;
             dy = 'd';
             //convert
             Console.WriteLine("enter");
             int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(num);
             Console.WriteLine("enter"); 
             int m = int.Parse(Console.ReadLine());
             Console.WriteLine(num);
             Console.ReadLine();
             //fors
             string str = "abghindsd";
             char[] array = str.ToCharArray();
             for (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine(array[i]);
             }
             Console.ReadLine();
             foreach(char ch in str.ToCharArray())
             {
                 Console.WriteLine(ch);
             }
             Console.Read();*/
            B ob = new B();

           // ob.lol();
            ob.lol2();
            //ob.M();
            Console.Read();

        }

        public override void abst() // compulsory to implement the abstract method
        {
            throw new NotImplementedException();
            //boiler plate code
        }
        public override void absv() // not compulsory to implement the virtual method
        {
            //boiler plate code
        }
    }
    class A
    {
        protected int i = 0;
        public virtual void M() //use the virtual keyword for polymorphism
        {
            Console.WriteLine("In M of A");
        }

        public void lol()
        {
            Console.WriteLine("on class A");
        }
    }
    class B : A
    {
        public void lol2()
        {
            Console.WriteLine("on class B");
            Console.WriteLine(i);
            this.M();

        }
        public override void M() // use the override keyword  for virtual methods
        {
            base.M(); // calling overriden method of A class
            Console.WriteLine("In M of B");
        }
    }
    //abstract class
    abstract class Abs //abstract class can have both virtual and abstract method
    {
        public abstract void abst();
        public virtual void  absv()
        {
            Console.WriteLine("virtual method in abstract class");
        }
    }
    //interface
    interface IF
    {
      void IF1();
      void IF2();
    }
    class Inteface_Implements : IF
    {
        public void IF1()
        {
            //boiler
        }

        public void IF2()
        {
           //boiler
        }
    }




}
 