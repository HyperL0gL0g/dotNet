using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace ISerializableImplement
{
    [Serializable]

    class Program:ISerializable
    {
        static Student student = new Student(1, "Abhi", "Kolkata", "B.Tech");
        static void Main(string[] args)
        {

            FileStream fileStream = new FileStream(@"D:\CAPGEMINI\Bin.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, student);
         
        }
    }
}
