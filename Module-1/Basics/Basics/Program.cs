using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiples();
            // unique();
            // duplicates();
            // frequency();
            // minMax();
            // separate();
            // reverse();
            // words();
            // maxFreq();
            //sub();
           // position();

        }
         // ------------------------------------------------------------------ Array------------------------------------
        static void multiples()
        {
            for(int i=1;i<=500;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }

        static void unique()
        {
            int[] arr = { 1, 2, 3, 4, 4, 3, 2, 1, 6, 7 };
            int n = arr.Length;
            Dictionary<int,int> map = new Dictionary<int, int>(); //num->count

            for(int i=0;i<n;i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    int count = map[arr[i]];
                    map[arr[i]] = count + 1;
                }
                else
                    map.Add(arr[i], 1);
            }
            foreach(int i   in map.Keys)
            {
                if(map[i]==1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }


        static void duplicates()
        {
            int[] arr = { 1, 2, 3, 4, 4, 3, 2, 1, 6, 7 };
            int n = arr.Length;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    int count = map[arr[i]];
                    map[arr[i]] = count + 1;
                }
                else
                    map.Add(arr[i], 1);
            }
            foreach (int i in map.Keys)
            {
                if (map[i] > 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }


        static void frequency()
        {
            int[] arr = { 1, 2, 3, 4, 4, 3, 2, 1, 6, 7 };
            int n = arr.Length;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    int count = map[arr[i]];
                    map[arr[i]] = count + 1;
                }
                else
                    map.Add(arr[i], 1);
            }
            foreach (int i in map.Keys)
            {
              
                    Console.WriteLine(i + " occurs " + map[i]+" times" );  
            }
            Console.ReadLine();
        }

        static void minMax()
        {
            int[] arr = { 1, 2, 3, 4, 4, 3, 2, 1, 6, 7 };
            Array.Sort(arr);
            Console.WriteLine("Minimum = " + arr[0] + " Maximum= " +arr[arr.Length-1]);
            Console.ReadLine();
        }
          // ------------------------------------String------------------------------------------

    static void separate()
        {
            string s = " Hello I am CR7 and i am better than Messi";
            for(int i = 0;i<s.Length;i++)
            {
                Console.Write(s[i]+" ");
            }
            Console.ReadLine();
        }

        static void reverse()
        {
            string s = " Hello I am CR7 and i am better than Messi";
            for (int i = s.Length-1; i >=0 ; i--)
            {
                Console.Write(s[i] + " ");
            }
            Console.ReadLine();
        }

        static void words()
        {
            string s = " Hello I am CR7 and i am better than Messi ".Trim();
            string[] w = s.Split(' ');
            for (int i = 0; i < w.Length; i++)
                Console.WriteLine(w[i]);
            Console.WriteLine();
            Console.WriteLine("Number of words= " + w.Length);
            Console.ReadLine();

        }

        static void maxFreq()
        { // asssuming the string has one max word
            String s = "yolo We only live once dont waste your life , yolo yolo !";
            string[] w = s.Split(' ');
            Dictionary<string, int> map = new Dictionary<string, int>();
            int max = 0;
            string ans = "";
            for(int i=0;i<w.Length;i++)
            {
                string curr = w[i];
                if (map.ContainsKey(curr))
                {
                    int c = map[curr];
                    map[curr] = c + 1;
                    if (c + 1 > max)
                    {
                        max = c;
                        ans = curr;
                    }
                }
                else
                    map[curr] = 1;
            }
            Console.WriteLine("Most frequent word = " + ans);
            Console.ReadLine();

        }

         static void sub()
        {

           
            String str = "I am Abhinav";
            String substr1 = "Abhi";
            String substr2 = "Capgemini";
            Console.WriteLine(str.Contains(substr1));
            Console.WriteLine(str.Contains(substr2));
            Console.ReadLine();
        }

        static void position()
        {
            string s = " We are doing training at capgemini from 8:30 to 6:00 6 days a week";
            int i = s.IndexOf("training");
            if(i==-1)
            {
                Console.WriteLine("not present");
            }
            else
            {
                Console.WriteLine("present at index =" + i);
            }
            Console.ReadLine();
        }


        // ---------------------------END----------------------















    }
}
