using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //map in c#
            Hashtable map = new Hashtable();
            for (int i = 0; i < 10; i++)
            {
                map.Add(i, i + 10);
            }
            bool f = map.ContainsKey(0);
            bool t = map.ContainsValue(1);
            foreach (int i in map.Keys)
            {
                Console.WriteLine(i + " " + map[i]);
            }
            Console.ReadLine();
            //Queue
            Queue q = new Queue();
            q.Enqueue("Abhi");
            q.Enqueue("Abhinav");
            q.Enqueue("Ghosh");
            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());
            Console.ReadLine();
            //stack
            Stack stackObject = new Stack();
            stackObject.Push("Joydip");
            stackObject.Push("Steve");
            stackObject.Push("Jini");
            while (stackObject.Count > 0)
                Console.WriteLine(stackObject.Pop());
            Console.ReadLine();

            //ArrayList
            int intValue = 100;
            double doubleValue = 20.5;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("John");
            arrayList.Add(intValue);
            arrayList.Add(doubleValue);
            for (int index = 0; index < arrayList.Count; index++)
                Console.WriteLine(arrayList[index]);
            Console.ReadLine();

        }

    }
}
