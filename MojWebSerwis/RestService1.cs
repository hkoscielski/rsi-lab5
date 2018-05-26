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
        private List<Book> books;

        public RestService1()
        {
            books = new List<Book>()
            {
                new Book { id = 1, title = "Pan Tadeusz", price = 19.99 },
                new Book { id = 2, title = "Harry Potter", price = 29.99 },
                new Book { id = 3, title = "Ostatnie życzenie", price = 34.99 }                
            };
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public Book GetById(string id)
        {
            int intId = int.Parse(id);
            return books.Find(b => b.id == intId);
        }

        public List<Book> GetJsonAll()
        {
            return books;
        }

        public Book GetJsonById(string id)
        {
            int intId = int.Parse(id);
            return books.Find(b => b.id == intId);
        }

        public string Update(string id, Book element)
        {
            if (element == null)
                throw new ArgumentNullException("Blad update");
            int idx = books.FindIndex(b => b.id == element.id);
            if (idx == -1)
                return "Nie mozna zaktualizowac elementu o id=" + id;
            books.RemoveAt(idx);
            books.Add(element);
            return "Zaktualizowano element o id=" + id;
        }

        public string UpdateJson(string id, Book element)
        {
            if (element == null)
                throw new ArgumentNullException("Blad update");
            int idx = books.FindIndex(b => b.id == element.id);
            if (idx == -1)
                return "Nie mozna zaktualizowac elementu o id=" + id;
            books.RemoveAt(idx);
            books.Add(element);
            return "Zaktualizowano element o id=" + id;
        }
    }
}
