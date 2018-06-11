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
    /// <summary>
    /// Pomocznicza klasa statyczna. Zapewnia serializację i deserializację danych w formacie JSON.
    /// Zapewnia metody konwertujące między: obiekt w formacie JSON, a obiektem Studenta lub Listą Studentów. W obie strony.
    /// Autor: 228172. Hubert Kościelski.
    /// </summary>
    static class JsonParser
    {
        /// <summary>
        /// Metoda statyczna zapewniająca serializację obiektu Studenta do obiektu w formacie JSON.
        /// </summary>
        /// <param name="student">Student Obiekt Studenta, który powinien zostać zwrócony w formacie JSON.</param>
        /// <returns>string Napis będący obiektem w formacie JSON powstały z serializacji obiektu Studenta.</returns>
        public static string WriteFromObject(Student student)
        {
            MemoryStream ms = new MemoryStream();

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Student));
            ser.WriteObject(ms, student);
            byte[] json = ms.ToArray();
            ms.Close();
            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        /// <summary>
        /// Metoda statyczna zapewniająca deserializację obiektu w formacie JSON do obiektu Studenta.
        /// </summary>
        /// <param name="json">string Napis będący obiektem Studenta w formacie JSON.</param>
        /// <returns>Student Obiekt Studenta powstały wskutek deserializacji obiektu JSON.</returns>
        public static Student ReadToObject(string json)
        {
            Student deserializedStudent = new Student();

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedStudent.GetType());
            deserializedStudent = ser.ReadObject(ms) as Student;
            ms.Close();
            return deserializedStudent;
        }

        /// <summary>
        /// Metoda statyczna zapewniająca deserializację listy obiektów w formacie JSON do Listy Studentów.
        /// </summary>
        /// <param name="json">string Napis będący listą obiektów (Studentów) w formacie JSON.</param>
        /// <returns>Lista Studentów Lista powstała wskutek deserializacji obiektu JSON.</returns>
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
