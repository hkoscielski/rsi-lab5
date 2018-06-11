using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Klasa odpowiedzialna za wysyłanie żądań do serwisu webowego. 
/// Wysyła żądania operacji CRUD dla studenta.
/// </summary>
public class Client
{
    //private const string BASE_URI = "http://192.168.0.7:3000/Service1.svc";
    private const string BASE_URI = "http://localhost:50892/Service1.svc";
    private const int CODEPAGE = 65001;
    private const string FORMAT = "json";
    private const string JSON_CONTENT_TYPE = "application/json";
    private const string JSON_RESOURCE_STUDENTS = "/json/students";
    private const string SLASH = "/";

    /// <summary>
    /// Enumerator oznaczający typ metody na żądanie - odpowiedź pomiędzy klientem a serwerem.
    /// </summary>
    private enum Method
    {
        DELETE,
        GET,
        POST,
        PUT
    }

    /// <summary>
    /// Metoda przesyłająca żądanie metodą POST do serwera, w celu utworzenia nowego studenta w serwisie.
    /// </summary>
    /// <param name="jsonStudent">string - obiekt JSON reprezentujący studenta, który ma zostać utworzony w serwisie.</param>
    /// <returns>string - JSON z odpowiedzią, czy żądanie zostało zrealizowane pomyślnie.</returns>
    public string CreateJsonStudent(string jsonStudent)
    {
        string _uri = string.Format("{0}{1}", BASE_URI, JSON_RESOURCE_STUDENTS);
        HttpWebRequest _req = WebRequest.Create(_uri) as HttpWebRequest;
        _req.KeepAlive = false;
        _req.Method = Enum.GetName(typeof(Method), Method.POST);
        _req.ContentType = JSON_CONTENT_TYPE;

        byte[] _buffer = Encoding.UTF8.GetBytes(jsonStudent);
        _req.ContentLength = _buffer.Length;
        Stream _postData = _req.GetRequestStream();
        _postData.Write(_buffer, 0, _buffer.Length);
        _postData.Close();

        HttpWebResponse _resp = _req.GetResponse() as HttpWebResponse;
        Encoding _enc = System.Text.Encoding.GetEncoding(CODEPAGE);
        StreamReader _responseStream = new StreamReader(_resp.GetResponseStream(), _enc);
        string _responseString = _responseStream.ReadToEnd();
        _responseStream.Close();
        _resp.Close();

        return _responseString;
    }

    /// <summary>
    /// Metoda przesyłająca żądanie metodą DELETE do serwera, w celu usunięcia z serwisu studenta o podanym numerze indeksu.
    /// </summary>
    /// <param name="index">string - numer indeksu studenta, który ma zostać usunięty z serwisu.</param>
    /// <returns>string - JSON z odpowiedzią, czy żądanie zostało zrealizowane pomyślnie.</returns>
    public string DeleteJsonStudent(string index)
    {
        string _uri = string.Format("{0}{1}{2}{3}", BASE_URI, JSON_RESOURCE_STUDENTS, SLASH, index);
        HttpWebRequest _req = WebRequest.Create(_uri) as HttpWebRequest;
        _req.KeepAlive = false;
        _req.Method = Enum.GetName(typeof(Method), Method.DELETE);
        _req.ContentType = JSON_CONTENT_TYPE;

        HttpWebResponse _resp = _req.GetResponse() as HttpWebResponse;
        Encoding _enc = System.Text.Encoding.GetEncoding(CODEPAGE);
        StreamReader _responseStream = new StreamReader(_resp.GetResponseStream(), _enc);
        string _responseString = _responseStream.ReadToEnd();
        _responseStream.Close();
        _resp.Close();

        return _responseString;
    }

    /// <summary>
    /// Metoda przesyłająca żądanie metodą GET do serwera, w celu pobrania z serwisu studenta o podanym numerze indeksu.
    /// </summary>
    /// <param name="index">string - numer indeksu studenta, który ma zostać pobrany z serwisu.</param>
    /// <returns>string - obiekt JSON reprezentujący studenta lub opis niepowodzenia realizacji żądania.</returns>
    public string LoadJsonStudent(string index)
    {
        string _uri = string.Format("{0}{1}{2}{3}", BASE_URI, JSON_RESOURCE_STUDENTS, SLASH, index);
        HttpWebRequest _req = WebRequest.Create(_uri) as HttpWebRequest;
        _req.KeepAlive = false;
        _req.Method = Enum.GetName(typeof(Method), Method.GET);
        _req.ContentType = JSON_CONTENT_TYPE;

        HttpWebResponse _resp = _req.GetResponse() as HttpWebResponse;
        Encoding _enc = System.Text.Encoding.GetEncoding(CODEPAGE);
        StreamReader _responseStream = new StreamReader(_resp.GetResponseStream(), _enc);
        string _responseString = _responseStream.ReadToEnd();
        _responseStream.Close();
        _resp.Close();

        return _responseString;
    }

    /// <summary>
    /// Metoda przesyłająca żądanie metodą GET do serwera, w celu pobrania z serwisu wszystkich studentów.
    /// </summary>
    /// <returns>string - tablica JSON reprezentująca wszystkich studentów lub opis niepowodzenia realizacji żądania.</returns>
    public string LoadAllJsonStudents()
    {
        string _uri = string.Format("{0}{1}", BASE_URI, JSON_RESOURCE_STUDENTS);
        HttpWebRequest _req = WebRequest.Create(_uri) as HttpWebRequest;
        _req.KeepAlive = false;
        _req.Method = Enum.GetName(typeof(Method), Method.GET);
        _req.ContentType = JSON_CONTENT_TYPE;

        HttpWebResponse _resp = _req.GetResponse() as HttpWebResponse;
        Encoding _enc = System.Text.Encoding.GetEncoding(CODEPAGE);
        StreamReader _responseStream = new StreamReader(_resp.GetResponseStream(), _enc);
        string _responseString = _responseStream.ReadToEnd();
        _responseStream.Close();
        _resp.Close();

        return _responseString;
    }

    /// <summary>
    /// Metoda przesyłająca żądanie metodą PUT do serwera, w celu modyfikacji w serwisie danych studenta o określonym numerze indeksu.
    /// </summary>
    /// <param name="index">string - numer indeksu studenta, którego dane mają zostać zmodyfikowane.</param>
    /// <param name="jsonStudent">string - obiekt JSON reprezentujący studenta ze zmodyfikowanymi danymi, którymi mają zostać nadpisane dane studenta o określonym numerze indeksu w serwisie.</param>
    /// <returns>string - JSON z odpowiedzią, czy żądanie zostało zrealizowane pomyślnie.</returns>
    public string UpdateJsonStudent(string index, string jsonStudent)
    {
        string _uri = string.Format("{0}{1}{2}{3}", BASE_URI, JSON_RESOURCE_STUDENTS, SLASH, index);
        HttpWebRequest _req = WebRequest.Create(_uri) as HttpWebRequest;
        _req.KeepAlive = false;
        _req.Method = Enum.GetName(typeof(Method), Method.PUT);
        _req.ContentType = JSON_CONTENT_TYPE;

        byte[] _buffer = Encoding.UTF8.GetBytes(jsonStudent);
        _req.ContentLength = _buffer.Length;
        Stream _postData = _req.GetRequestStream();
        _postData.Write(_buffer, 0, _buffer.Length);
        _postData.Close();

        HttpWebResponse _resp = _req.GetResponse() as HttpWebResponse;
        Encoding _enc = System.Text.Encoding.GetEncoding(CODEPAGE);
        StreamReader _responseStream = new StreamReader(_resp.GetResponseStream(), _enc);
        string _responseString = _responseStream.ReadToEnd();
        _responseStream.Close();
        _resp.Close();

        return _responseString;
    }
}
