using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MojWebSerwis
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class RestService1 : IRestService1
    {
        private List<Student> students;

        public RestService1()
        {
            students = new List<Student>()
            {
                new Student { index = "222223", firstName = "Michał", lastName = "Kościelski", city = "Konin", yearOfBirth = 1996 },
                new Student { index = "242134", firstName = "Stefan", lastName = "Kowalski", city = "Wrocław", yearOfBirth = 1997 },
                new Student { index = "215123", firstName = "Anna", lastName = "Nowak", city = "Opole", yearOfBirth = 1995 }
            };            
        }

        public string Create(Student student)
        {
            int i = students.FindIndex(s => s.index == student.index);
            if (i != -1)
            {
                return string.Format("Dodawanie niepomyślne. Student o indeksie {0} już istnieje", student.index);
            }
            students.Add(student);
            return string.Format("Dodano studenta o indeksie {0}", student.index);
        }

        public string CreateJson(Student student)
        {
            int i = students.FindIndex(s => s.index == student.index);
            if (i != -1)
            {
                return string.Format("Dodawanie niepomyślne. Student o indeksie {0} już istnieje", student.index);
            }
            students.Add(student);
            return string.Format("Dodano studenta o indeksie {0}", student.index);
        }

        public string Delete(string index)
        {
            int i = students.FindIndex(s => s.index == index);
            if (i == -1)
            {
                return string.Format("Usuwanie niepomyślne. Nie znaleziono studenta o indeksie {0}", index);
            }
            students.RemoveAt(i);            
            return string.Format("Usunięto studenta o indeksie {0}", index);
        }

        public string DeleteJson(string index)
        {
            int i = students.FindIndex(s => s.index == index);
            if (i == -1)
            {
                return string.Format("Usuwanie niepomyślne. Nie znaleziono studenta o indeksie {0}", index);
            }
            students.RemoveAt(i);
            return string.Format("Usunięto studenta o indeksie {0}", index);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(string index)
        {            
            return students.Find(s => s.index == index);
        }

        public List<Student> GetJsonAll()
        {
            return students;
        }

        public Student GetJsonById(string index)
        {
            return students.Find(s => s.index == index);
        }

        public string Update(string index, Student student)
        {
            if(student == null)
            {
                throw new ArgumentNullException("Student is null");
            }
            int i = students.FindIndex(s => s.index == student.index);
            if(i == -1)
            {
                return string.Format("Nie mozna zaktualizowac danych studenta o indeksie {0}", index);
            }
            students.RemoveAt(i);
            students.Add(student);
            return string.Format("Zaktualizowano dane studenta o indeksie {0}", index);
        }

        public string UpdateJson(string index, Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student is null");
            }
            int i = students.FindIndex(s => s.index == student.index);
            if (i == -1)
            {
                return string.Format("Nie mozna zaktualizowac danych studenta o indeksie {0}", index);
            }
            students.RemoveAt(i);
            students.Add(student);
            return string.Format("Zaktualizowano dane studenta o indeksie {0}", index);
        }
    }
}
