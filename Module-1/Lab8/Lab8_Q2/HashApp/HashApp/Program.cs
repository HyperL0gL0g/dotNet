using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashApp
{
    class Program
    {
        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }

        static void Main(string[] args)
        {
            Hashtable hashtable = GetHashtable();
            if (hashtable.ContainsKey("Perimeter")) //check if hashtable contians perimeter or not
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.WriteLine("Area = " + hashtable["Area"]); //print the area
            hashtable.Remove("Mortgage");//reomve entry
            Console.WriteLine(hashtable.Count);//print count 
            Console.ReadLine();
        }
    }
}
