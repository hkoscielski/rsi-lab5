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
                return string.Format("Nie mozna zaktualizowac elementu o id = {0}", index);
            }
            students.RemoveAt(i);
            students.Add(student);
            return string.Format("Zaktualizowano element o id = {0}", index);
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
                return string.Format("Nie mozna zaktualizowac elementu o id = {0}", index);
            }
            students.RemoveAt(i);
            students.Add(student);
            return string.Format("Zaktualizowano element o id = {0}", index);
        }
    }
}
