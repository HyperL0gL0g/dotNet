using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using participantslib;

namespace lab3_q1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        int[] arr = {1,2,3,4,5,1,2,3,4,5,6,7}; //12
            IDictionary<int, int> map = new Dictionary<int, int>();
            for(int i=0;i<12;i++)
                {
                    map.Add(arr[i],map[arr[i]]+1);
                }
            int c=0;
            for(int i  : map)
                {
            
               if(i.Value>1)
                    c++:
            }

            Console.WriteLine(c);
        }
    }
}
