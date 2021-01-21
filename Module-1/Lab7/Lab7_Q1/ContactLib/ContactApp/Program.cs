using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactLib;

namespace ContactApp
{
    
   
    class Program
    {
        static List<Contact> contactList = new List<Contact>();

        static void addContact()
        {
            Console.WriteLine("Enter Contact Details: ");

            Console.WriteLine("Enter Contact No: ");
            int ContactNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Contact Name: ");
            string ContactName = Console.ReadLine();

            Console.WriteLine("Enter cell No: ");
            string CellNo = Console.ReadLine();

            contactList.Add(new Contact(ContactNo, ContactName, CellNo));
        }

        static void displayContact(String contactName)
        {

         

            foreach(Contact contact in contactList)
            {
                if (contact.ContactName.Equals(contactName))
                {
                    Console.WriteLine("Contact Details: ");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(" Number: " + contact.ContactNo);
                    Console.WriteLine(" Name: " + contact.ContactName);
                    Console.WriteLine("Cell : " + contact.CellNo);
                    return;
                }
            }

            Console.WriteLine("Contact Name " + contactName + " does not exist");
        }

        static void editContact(string contactName)
        {
            foreach (Contact contact in contactList)
            {
                if (contact.ContactName.Equals(contactName))
                {
                    Console.WriteLine("Enter Contact Details to modify: ");

                    Console.WriteLine("Enter modified Contact No: ");
                    contact.ContactNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter modified Contact Name: ");
                    contact.ContactName = Console.ReadLine();

                    Console.WriteLine("Enter modified cell No: ");
                    contact.CellNo = Console.ReadLine();

                    return;
                }
            }

            Console.WriteLine("Contact Name " + contactName + " does not exist so can't modify");
        }

        static void showAllDetails()
        {
            foreach(Contact contact in contactList)
            {
                Console.WriteLine();
                Console.WriteLine(contact.ContactName);
                displayContact(contact.ContactName);
            }
        }
        static void Main(string[] args)
        {
            int choice;
            char cont;
            do
            {
                Console.WriteLine("Choose\n 1) Add Contact \n 2) Displaycontact\n 3) Edit contact\n 4) show all contact\n 0) exit");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        return;
                        break;
                    case 1:
                        addContact();
                        break;
                    case 2: 
                        Console.WriteLine("Enter the name of the contact whose details you want to display");
                        string name = Console.ReadLine();
                        displayContact(name);
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of the contact whose details you want to modify");
                        string name2 = Console.ReadLine();
                        editContact(name2);
                        break;
                    case 4:
                        showAllDetails();
                        break;                
                    default:
                        Console.WriteLine("Please enter correct option");
                        break;
                }

                Console.WriteLine("Want to Continue? y/n");
                cont = Convert.ToChar(Console.ReadLine());
            } while (cont == 'y');
        }
    }
}
