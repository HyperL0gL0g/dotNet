using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// program to show workings of a map(aka dictionary)
namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("Ronaldo", "Juve");
            dictionary.Add("Messi", "Barca");
            dictionary.Add("Ramos", "Real");
            //updation
            dictionary["Messi"] = "ManC";
            dictionary["Ramos"] = "Juve";
            //try catch to show that we cannot add duplicate entries
            try{
            dictionary.Add("Messi", "ManC");
            }
            catch(Exception e)
            {
                 Console.WriteLine("Key-value already there");
            }

            //try catch block to add new key(if not present already)
            try{
                Console.WriteLine(dictionary["Marcelo"]);
            }
            catch(KeyNotFoundException e) // if key is not found then we add it 
            {
                dictionary["Marcelo"] = "Inter";
            }
            //printing the dict
            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                Console.WriteLine(entry.Key + "->" + entry.Value);
            }
           //remove
            dictionary.Remove("Messi");
            Console.ReadLine();
        }
    }
}
