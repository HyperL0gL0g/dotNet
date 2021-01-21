using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics3
{
    class MyString
    {
        public static void Main(string[] args)
        {
            // indiChar("Anish");
            //revChar("Anish");
            //Console.WriteLine(countWords("nepal is a beautiful country"));

            //Console.WriteLine(maxOChar("Annisssh"));
            //Console.WriteLine(isSubstring("Anish", "Ani"));
            Console.WriteLine(subStringPos("Anish", "sh"));
            Console.ReadKey();
        }

        static int subStringPos(string str,string sub)
        {
            return str.IndexOf(sub);
        }
        static bool isSubstring(string str,string sub)
        {
            return str.Contains(sub);
        }
        static char maxOChar(string str)
        {
            int[] arr = new int[str.Length];

            for(int i = 0; i < str.Length; ++i)
            {
                int count = 1;
                for(int j = i + 1; j < str.Length && arr[i]!=-1; ++j)
                {
                    if (str[i] == str[j])
                    {
                        ++count;
                        arr[j] = -1;
                    }
                }
                if (arr[i] != -1)
                    arr[i] = count;
            }

            int max = int.MinValue;
            int max_index = -1;
            for(int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] != -1)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                        max_index = i;
                    }
                }
            }
            return str[max_index];
        }
        static int countWords(string str)
        {
            int count = 0;
            str=str.Trim();
            for(int i = 0; i < str.Length-1; ++i)
            {
                if (str[i] == ' ' && char.IsLetterOrDigit(str[i + 1]))
                    ++count;
            }
            return count+1;
        }
        static void revChar(string str)
        {
            char[] arr = str.ToCharArray();
            reverseChar(arr);
            foreach (char ch in arr)
            {
                Console.WriteLine(ch);
            }
        }

        static void reverseChar(char[] arr)
        {
            int l = 0, r = arr.Length-1;
            while (l < r)
            {
                char ch = arr[l];
                arr[l] = arr[r];
                arr[r] = ch;
                ++l;
                --r;
            }
        }
        static void indiChar(string str)
        {
            char[] arr = str.ToCharArray();
            foreach(char ch in arr)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
