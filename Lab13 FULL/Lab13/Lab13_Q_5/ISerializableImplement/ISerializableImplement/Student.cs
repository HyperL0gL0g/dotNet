using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ISerializableImplement
{
    [Serializable]
    class Student : ISerializable
    {
        public int rollNo;
        public string name;
        public string city;
        public string degree;

        public Student(int rollNo, string name, string city, string degree)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.city = city;
            this.degree = degree;

        }

        public Student(SerializationInfo info, StreamingContext context) //calls during deserialization
        {
            this.rollNo = info.GetInt32("rollno:");
            this.name = info.GetString("name:");
            this.city = info.GetString("city:");
            this.degree = info.GetString("degree:");
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("rollno:", this.rollNo);
            info.AddValue("name:", this.name);
            info.AddValue("city:", this.city);
            info.AddValue("degree:", this.degree);
        }
    }
}
