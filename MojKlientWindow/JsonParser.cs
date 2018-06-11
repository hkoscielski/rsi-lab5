using MojWebSerwis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MojKlientWindow
{
    static class JsonParser
    {
        public static string WriteFromObject(Student student)
        {
            MemoryStream ms = new MemoryStream();

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Student));
            ser.WriteObject(ms, student);
            byte[] json = ms.ToArray();
            ms.Close();
            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        public static Student ReadToObject(string json)
        {
            Student deserializedStudent = new Student();

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedStudent.GetType());
            deserializedStudent = ser.ReadObject(ms) as Student;
            ms.Close();
            return deserializedStudent;
        }

        public static List<Student> ReadToListOfObjects(string json)
        {
            List<Student> deserializedList = new List<Student>();

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedList.GetType());
            deserializedList = ser.ReadObject(ms) as List<Student>;
            ms.Close();
            return deserializedList;
        }
    }
}
