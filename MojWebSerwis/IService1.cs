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
        [WebInvoke(UriTemplate = "/students",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Xml)]
        string Create(Student student);

        [OperationContract]
        [WebGet(UriTemplate = "/students",
            ResponseFormat = WebMessageFormat.Xml)]
        List<Student> GetAll();

        [OperationContract]
        [WebGet(UriTemplate = "/students/{index}",
            ResponseFormat = WebMessageFormat.Xml)]
        Student GetById(string index);

        [OperationContract]
        [WebInvoke(UriTemplate = "/students/{index}",
            Method = "PUT",
            RequestFormat = WebMessageFormat.Xml)]
        string Update(string index, Student student);

        [OperationContract]
        [WebInvoke(UriTemplate = "/students/{index}",
            Method = "DELETE",
            RequestFormat = WebMessageFormat.Xml)]
        string Delete(string index);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/students",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        string CreateJson(Student student);

        [OperationContract]
        [WebGet(UriTemplate = "/json/students",
            ResponseFormat = WebMessageFormat.Json)]
        List<Student> GetJsonAll();

        [OperationContract]
        [WebGet(UriTemplate = "/json/students/{index}",
            ResponseFormat = WebMessageFormat.Json)]
        Student GetJsonById(string index);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/students/{index}",
            Method = "PUT",
            RequestFormat = WebMessageFormat.Json)]
        string UpdateJson(string index, Student student);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/students/{index}",
            Method = "DELETE",
            RequestFormat = WebMessageFormat.Json)]
        string DeleteJson(string index);
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        public string index;
        [DataMember]
        public string firstName;
        [DataMember]
        public string lastName;
        [DataMember]
        public string city;
        [DataMember]
        public int yearOfBirth;
    }
}
