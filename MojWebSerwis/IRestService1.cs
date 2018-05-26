using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MojWebSerwis
{
    [ServiceContract]
    public interface IRestService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/books",
            ResponseFormat = WebMessageFormat.Xml)]
        List<Book> GetAll();

        [OperationContract]
        [WebGet(UriTemplate = "/books/{id}",
            ResponseFormat = WebMessageFormat.Xml)]
        Book GetById(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/books/{id}",
            Method = "PUT",
            RequestFormat = WebMessageFormat.Xml)]
        string Update(string id, Book element);

        [OperationContract]
        [WebGet(UriTemplate = "/json/books",
            ResponseFormat = WebMessageFormat.Json)]
        List<Book> GetJsonAll();

        [OperationContract]
        [WebGet(UriTemplate = "/json/books/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        Book GetJsonById(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/books/{id}",
            Method = "PUT",
            RequestFormat = WebMessageFormat.Json)]
        string UpdateJson(string id, Book element);
    }

    [DataContract]
    public class Book
    {
        public int id;
        public string title;
        public double price;
    }
}
