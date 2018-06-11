using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public class Client
{
    private const string BASE_URI = "http://192.168.0.7:3000/Service1.svc";
    private const int CODEPAGE = 1252;
    private const string FORMAT = "json";
    private const string JSON_CONTENT_TYPE = "application/json";
    private const string RESOURCE_STUDENTS = "/students";
    private const string SLASH = "/";

    private enum Method
    {
        DELETE,
        GET,
        POST,
        PUT
    }

    private string CreateJsonStudent(string jsonStudent)
    {
        string _uri = string.Format("{0}{1}", BASE_URI, RESOURCE_STUDENTS);
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

    private string DeleteJsonStudent(string index)
    {
        string _uri = string.Format("{0}{1}{2}{3}", BASE_URI, RESOURCE_STUDENTS, SLASH, index);
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

    private string LoadJsonStudent(string index)
    {
        string _uri = string.Format("{0}{1}{2}{3}", BASE_URI, RESOURCE_STUDENTS, SLASH, index);
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

    private string LoadAllJsonStudents()
    {
        string _uri = string.Format("{0}{1}", BASE_URI, RESOURCE_STUDENTS);
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

    private string UpdateJsonStudent(string index, string jsonStudent)
    {
        string _uri = string.Format("{0}{1}{2}{3}", BASE_URI, RESOURCE_STUDENTS, SLASH, index);
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
