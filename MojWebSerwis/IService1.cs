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
    /// Interfejs kontraktu. Zawiera sygnatury metod, które powinny być implementowane przez kontrakt.
    /// Autor: 228172, Hubert Kościelski.
    /// </summary>
    [ServiceContract]
    public interface IRestService1
    {
        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu POST w celu dodania nowego studenta do serwisu. 
        /// </summary>
        /// <param name="student">Student - obiekt reprezentujący studenta, który ma zostać dodany do serwisu</param>
        /// <returns>string - Xml z odpowiedzią, czy żądanie dodania studenta zostało zrealizowane pomyślnie.</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/students",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Xml)]
        string Create(Student student);

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu GET w celu pobrania listy wszystkich studentów z serwisu. 
        /// </summary>
        /// <returns>List<Student> - lista wszystkich studentów pobranych z serwisu w formacie Xml.</Student></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/students",
            ResponseFormat = WebMessageFormat.Xml)]
        List<Student> GetAll();

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu GET w celu pobrania z serwisu studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, który ma zostać pobrany z serwisu.</param>
        /// <returns>Student - student pobrany z serwisu w formacie Xml.</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/students/{index}",
            ResponseFormat = WebMessageFormat.Xml)]
        Student GetById(string index);

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu PUT w celu modyfikacji w serwisie dane studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, którego dane w serwisie mają zostać zmodyfikowane.</param>
        /// <param name="student">string - obiekt reprezentujący studenta ze zmodyfikowanymi danymi, którymi mają zostać nadpisane dane studenta o określonym numerze indeksu w serwisie.</param>
        /// <returns>string - Xml z odpowiedzią, dane studenta zostały zmodyfikowane pomyślnie.</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/students/{index}",
            Method = "PUT",
            RequestFormat = WebMessageFormat.Xml)]
        string Update(string index, Student student);

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu DELETE w celu usunięcia z serwisu studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, który ma zostać usunięty z serwisu.</param>
        /// <returns>string - Xml z odpowiedzią, czy student został usunięty pomyślnie.</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/students/{index}",
            Method = "DELETE",
            RequestFormat = WebMessageFormat.Xml)]
        string Delete(string index);

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu POST w celu dodania nowego studenta do serwisu. 
        /// </summary>
        /// <param name="student">Student - obiekt reprezentujący studenta, który ma zostać dodany do serwisu</param>
        /// <returns>string - obiekt JSON z odpowiedzią, czy żądanie dodania studenta zostało zrealizowane pomyślnie. </returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/json/students",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        string CreateJson(Student student);

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu GET w celu pobrania listy wszystkich studentów z serwisu. 
        /// </summary>
        /// <returns>List<Student> - lista wszystkich studentów pobranych z serwisu w formacie JSON.</Student></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/json/students",
            ResponseFormat = WebMessageFormat.Json)]
        List<Student> GetJsonAll();

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu GET w celu pobrania z serwisu studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, który ma zostać pobrany z serwisu.</param>
        /// <returns>Student - student pobrany z serwisu w formacie JSON.</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/json/students/{index}",
            ResponseFormat = WebMessageFormat.Json)]
        Student GetJsonById(string index);

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu PUT w celu modyfikacji w serwisie dane studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, którego dane w serwisie mają zostać zmodyfikowane.</param>
        /// <param name="student">string - obiekt reprezentujący studenta ze zmodyfikowanymi danymi, którymi mają zostać nadpisane dane studenta o określonym numerze indeksu w serwisie.</param>
        /// <returns>string - obiekt JSON z odpowiedzią, dane studenta zostały zmodyfikowane pomyślnie.</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/json/students/{index}",
            Method = "PUT",
            RequestFormat = WebMessageFormat.Json)]
        string UpdateJson(string index, Student student);

        /// <summary>
        /// Operacja kontraktu.
        /// Metoda powinna odpowiadać na żądanie typu DELETE w celu usunięcia z serwisu studenta o określonym numerze indeksu. 
        /// </summary>
        /// <param name="index">string - numer indeksu studenta, który ma zostać usunięty z serwisu.</param>
        /// <returns>string - obiekt JSON z odpowiedzią, czy student został usunięty pomyślnie.</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/json/students/{index}",
            Method = "DELETE",
            RequestFormat = WebMessageFormat.Json)]
        string DeleteJson(string index);
    }

    /// <summary>
    /// Specjalny klasa dla kontraktu. Wykorzystywana jako ciało żądania przesyłane do serwera oraz odpowiedź stamtąd pochodzącą.
    /// Reprezentuje pojedynczego studenta.
    /// </summary>
    [DataContract]
    public class Student
    {
        /// <summary>
        /// string - numer indeksu studenta
        /// </summary>
        [DataMember]
        public string index;
        /// <summary>
        /// string - pierwsze imię studenta
        /// </summary>
        [DataMember]
        public string firstName;
        /// <summary>
        /// string - nazwisko studenta
        /// </summary>
        [DataMember]
        public string lastName;
        /// <summary>
        /// string - miasto zamieszkania studenta
        /// </summary>
        [DataMember]
        public string city;
        /// <summary>
        /// int - rok urodzenia studenta
        /// </summary>
        [DataMember]
        public int yearOfBirth;
    }
}
