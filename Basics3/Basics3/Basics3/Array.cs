using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics3
{
    class Array
    {
        static void Main(string[] args)
        {
            // mul3A5();
            //uniqArr(new int[]{2,3,2,4,3,5});
            //Console.WriteLine(countDupArr(new int[] { 2, 3, 2, 4, 3, 6,6 }));
            //frequency(new int[] { 2, 3, 3, 4, 2, 4, 2 });
            maxMin(new int[] { 9, 8, 4, 1, 33, 100, 4 });
            Console.ReadKey();
        }

        static void maxMin(int[] arr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i = 0; i < arr.Length; ++i)
            {
                if (max < arr[i])
                    max = arr[i];
                if (min > arr[i])
                    min = arr[i];
            }
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
        }
        static void frequency(int[] arr)
        {
            int[] freq = new int[arr.Length];
            for(int i = 0; i < arr.Length; ++i)
            {
                int count = 1;
                for(int j=i+1;j<arr.Length && freq[i] != -1; ++j)
                {
                    if(arr[i] == arr[j])
                    {
                        ++count;
                        freq[j] = -1;
                    }
                }
                if (freq[i] != -1)
                {
                    freq[i] = count;
                }
            }

            for(int i = 0; i < freq.Length; ++i)
            {
                if(freq[i]!=-1)
                Console.WriteLine(arr[i] + " occurs " + freq[i]+" times");
            }
        }
        static int countDupArr(int[] arr)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                int j = 0;
                for (; j < i; ++j)
                {
                    if (arr[i] == arr[j])
                        ++count;
                }
            }
            return count;
        }
        static void mul3A5()
        {
            int i = 15;
            while (i <= 500)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i);
                ++i;
            }
        }

        static void uniqArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; ++i)
            {
                int j = 0;
                for (; j < i; ++j)
                {
                    if (arr[j] == arr[i])
                        break;
                }
                if (i == j)
                    Console.WriteLine(arr[i]);
            }
        }
    }
}
