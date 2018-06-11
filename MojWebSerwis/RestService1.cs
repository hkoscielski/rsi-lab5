using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

/// <summary>
/// Przestrzeń nazw dotycząca projektu, który zawiera interfejs kontraktu serwisu i jego implementację.
/// Autor: 228172, Hubert Kościelski.
/// </summary>
namespace MojWebSerwis
{
    /// <summary>
    /// Klasa implementująca interfejs 'IRestService1'. 
    /// Obsługuje wszystkie metody zawarte w interfejsie.
    /// Autor: 228172, Hubert Kościelski.
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class RestService1 : IRestService1
    {
        /// <summary>
        /// List<Student> - lista studentów przechowywanych w serwisie. 
        /// </summary>
        private List<Student> students;

        /// <summary>
        /// Konstruktor bezparametrowy serwisu.
        /// Inicjalizuje listę studentów.
        /// </summary>
        public RestService1()
        {
            students = new List<Student>()
            {
                new Student { index = "222223", firstName = "Michał", lastName = "Kościelski", city = "Konin", yearOfBirth = 1996 },
                new Student { index = "242134", firstName = "Stefan", lastName = "Kowalski", city = "Wrocław", yearOfBirth = 1997 },
                new Student { index = "215123", firstName = "Anna", lastName = "Nowak", city = "Opole", yearOfBirth = 1995 }
            };            
        }

        /// <summary>
        /// Metoda dodająca nowego studenta do serwisu, jeśli taki jeszcze nie istnieje. 
        /// </summary>
        /// <param name="student">Student - obiekt reprezentujący studenta, który ma zostać dodany do serwisu</param>
        /// <returns>string - Xml z odpowiedzią, czy żądanie dodania studenta zostało zrealizowane pomyślnie.</returns>
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

        /// <summary>
        /// Metoda dodająca nowego studenta do serwisu, jeśli taki jeszcze nie istnieje. 
        /// </summary>
        /// <param name="student">Student - obiekt reprezentujący studenta, który ma zostać dodany do serwisu</param>
        /// <returns>string - obiekt JSON z odpowiedzią, czy żądanie dodania studenta zostało zrealizowane pomyślnie.</returns>
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

        /// <summary>        
        /// Metoda usuwająca z serwisu studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, który ma zostać usunięty z serwisu.</param>
        /// <returns>string - Xml z odpowiedzią, czy student został usunięty pomyślnie.</returns>
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

        /// <summary>        
        /// Metoda usuwająca z serwisu studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, który ma zostać usunięty z serwisu.</param>
        /// <returns>string - obiekt JSON z odpowiedzią, czy student został usunięty pomyślnie.</returns>
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

        /// <summary>        
        /// Metoda pobierająca listę wszystkich studentów z serwisu. 
        /// </summary>
        /// <returns>List<Student> - lista wszystkich studentów pobranych z serwisu w formacie Xml.</Student></returns>
        public List<Student> GetAll()
        {
            return students;
        }

        /// <summary>       
        /// Metoda pobierająca z serwisu studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, który ma zostać pobrany z serwisu.</param>
        /// <returns>Student - student pobrany z serwisu w formacie Xml.</returns>
        public Student GetById(string index)
        {            
            return students.Find(s => s.index == index);
        }

        /// <summary>        
        /// Metoda pobierająca listę wszystkich studentów z serwisu. 
        /// </summary>
        /// <returns>List<Student> - lista wszystkich studentów pobranych z serwisu w formacie JSON.</Student></returns>
        public List<Student> GetJsonAll()
        {
            return students;
        }

        /// <summary>       
        /// Metoda pobierająca z serwisu studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, który ma zostać pobrany z serwisu.</param>
        /// <returns>Student - student pobrany z serwisu w formacie JSON.</returns>
        public Student GetJsonById(string index)
        {
            return students.Find(s => s.index == index);
        }

        /// <summary>        
        /// Metoda modyfikująca w serwisie dane studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, którego dane w serwisie mają zostać zmodyfikowane.</param>
        /// <param name="student">string - obiekt reprezentujący studenta ze zmodyfikowanymi danymi, którymi mają zostać nadpisane dane studenta o określonym numerze indeksu w serwisie.</param>
        /// <returns>string - Xml z odpowiedzią, dane studenta zostały zmodyfikowane pomyślnie.</returns>
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

        /// <summary>        
        /// Metoda modyfikująca w serwisie dane studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, którego dane w serwisie mają zostać zmodyfikowane.</param>
        /// <param name="student">string - obiekt reprezentujący studenta ze zmodyfikowanymi danymi, którymi mają zostać nadpisane dane studenta o określonym numerze indeksu w serwisie.</param>
        /// <returns>string - obiekt JSON z odpowiedzią, dane studenta zostały zmodyfikowane pomyślnie.</returns>
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
