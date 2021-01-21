using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace XmlSerial
{
    class Program
    {
        static Supplier supplier = new Supplier();
        static Supplier[] supplierList = new Supplier[2];
        static void Main(string[] args)
        {
            initializer();
            serializeJSON();
        }
        static void initializer()
        {

            Supplier supplier = new Supplier();
            supplier.acceptDetails(supplier);
            supplierList[0] = supplier;
            supplier = new Supplier();
            supplier.acceptDetails(supplier);
            supplierList[1] = supplier;
        }
        static void serialize()
        {
            FileStream fileStream = new FileStream(@"D:\CAPGEMINI\XML.dat", FileMode.Create, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Supplier));
            xmlSerializer.Serialize(fileStream, supplier);
        }
        static void serializeJSON()
        {
            FileStream fileStream = new FileStream(@"D:\CAPGEMINI\JSON.dat", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(JsonConvert.SerializeObject(supplierList));
            streamWriter.Close();
            fileStream.Close();
        }

       
       
    }
}
