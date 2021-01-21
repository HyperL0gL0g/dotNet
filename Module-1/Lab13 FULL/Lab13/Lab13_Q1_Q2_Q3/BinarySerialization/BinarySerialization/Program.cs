using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Runtime.Serialization;

namespace BinarySerialization
{
   

    class Program
    { 
        static List<Contact> contactList = new List<Contact>();
   
        static void Main(string[] args)
        {
            Console.WriteLine(" app Started");
            contactList.Add(new Contact(1, "Abhi", "0001"));
            contactList.Add(new Contact(2, "Abhinav", "0002"));

            binarySerialize();   //SERIALIZE THE DATA and then deserialize it
       
            //soapSerialize();      //SERIALIZE THE DATA(SOAP)
            Console.ReadKey();
        }
        
         static void binarySerialize()
        {
         //   Contact obj = new Contact(1, "Abhi", "0001");
            Console.WriteLine("serialize");
            FileStream fileStream = new FileStream(@"D:\CAPGEMINI\BinF.dat", FileMode.Create, FileAccess.Write); //creating a file
            IFormatter binaryFormatter = new BinaryFormatter(); // implementing the iformatter interface
            binaryFormatter.Serialize(fileStream  contactList); //serialised into the file
            fileStream.Close(); //close the stream
            Console.WriteLine("Deserialize"); 
            fileStream = new FileStream(@"D:\CAPGEMINI\BinF.dat", FileMode.Open, FileAccess.Read); //open the stream
             List<Contact> list = binaryFormatter.Deserialize(fileStream) as List<Contact>; //deserialise 
         //   Contact ob = (Contact)binaryFormatter.Deserialize(fileStream);
         //   Console.WriteLine(ob.CellNo + " " + ob.ContactName + " " + ob.ContactNo);
            foreach(Contact contact in list)
            {
                Console.WriteLine(contact.ContactNo + " " + contact.ContactName + " " + contact.CellNo);
            }

        }
        static void soapSerialize()
        {
            FileStream fileStream = new FileStream(@"D:\CAPGEMINI\SoapF.dat", FileMode.Create, FileAccess.Write, FileShare.Read);
            SoapFormatter soapFormatter = new SoapFormatter();

            soapFormatter.Serialize(fileStream, contactList);
            fileStream.Close();
        }
       
       
       
    }
}
