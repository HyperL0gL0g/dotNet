using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace RTOApplication
{// collections hashtable 
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(); //hastable for storing
            int choice;
            char cont;
            do
            {
                Console.WriteLine("choose 1)Add RTO Record 2)search RTO record 3)Delete RTO Record 4)View all RTO record 5)Display Count 0)exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Enter RTO details");
                        Console.WriteLine("Enter RTO No");
                        int rtoNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Place name");
                        string name = Console.ReadLine();
                        hashtable.Add(rtoNo, name);
                        
                        break;
                    case 2:
                        Console.WriteLine("Enter the RTO No which you want to  search");
                        int rto = Convert.ToInt32(Console.ReadLine());
                        if (hashtable.ContainsKey(rto))
                        {
                            Console.WriteLine("Rto No: " + rto + " Place: " + hashtable[rto]);
                        }
                        else
                        {
                            Console.WriteLine("Rto no: " + rto + " doesn't exist");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the RTO No which you wanna search");
                        int rto1 = Convert.ToInt32(Console.ReadLine()); //search 
                        if (hashtable.ContainsKey(rto1))
                        {
                            hashtable.Remove(rto1);
                        }
                        else
                        {
                            Console.WriteLine("Rto no: " + rto1 + " doesn't exist");
                        }
                        break;
                    case 4:
                         foreach(DictionaryEntry entry in hashtable) //printing
                        {
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Rto No: " + entry.Key + " Place: " +entry.Value);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Count= " + hashtable.Count); //getting count of entries
                        break;
                    default:
                        Console.WriteLine("Enter proper option"); //wrong input
                        break;
                }
                Console.WriteLine("Wanna continue? y/n");
                cont = char.Parse(Console.ReadLine());
            } while (cont == 'y');
        }
    }
}
