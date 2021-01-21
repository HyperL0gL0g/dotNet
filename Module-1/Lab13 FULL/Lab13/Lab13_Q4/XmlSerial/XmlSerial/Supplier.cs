using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerial
{
    [Serializable]
    public class Supplier
    {
        public int supplierId;
        public string supplierName;
        public string city;
        public string phoneNo;
        public string email;

        public void acceptDetails(Supplier supplier)
        {
            Console.WriteLine("Enter supplier id");
            supplier.supplierId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter supplier name");
            supplier.supplierName = Console.ReadLine();

            Console.WriteLine("Enter city");
            supplier.city = Console.ReadLine();

            Console.WriteLine("Enter phone number");
            supplier.phoneNo = Console.ReadLine();

            Console.WriteLine("Enter email");
            supplier.email = Console.ReadLine();
        }
        public Supplier displayDetails()
        {
            return this;
        }
    }
}
