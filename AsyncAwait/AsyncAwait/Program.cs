using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static  void Main(string[] args)
        {
            M();
            Console.Read();
        }
        static async  void M()
        {
            // Task<int> t = new Task<int>(p);
            //t.Start();
          int c=  p();
          
            Console.WriteLine("Main here");
            Console.WriteLine("Calling func");
            // Task<int> t = new Task<int>(p);
            //  t.Start();
           // int c = await t;
            //  await t;
            Console.WriteLine("count= "+c);
            Console.WriteLine(" program Done");

        }
        static int p()
        {
            Console.WriteLine("Counting");
            int count = 0;
            using (StreamReader reader = new StreamReader("D:\\CAPGEMINI\\test.txt")) 
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
           // Console.WriteLine(count);

            Console.WriteLine(" counting Done");
            return count;
           // Console.ReadLine();
        }
    }
}
