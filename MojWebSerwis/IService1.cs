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
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        public string index;
        [DataMember]
        public string firstName;
        [DataMember]
        public double lastName;
        [DataMember]
        public string city;
        [DataMember]
        public int yearOfBirth;
    }
}
