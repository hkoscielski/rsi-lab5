//using MojWebSerwis;
using MojWebSerwis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO;

namespace MojKlientWindow
{
    public partial class Form1 : Form
    {
        private List<Student> students;        

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
        
        public Form1()
        {
            InitializeComponent();            
            students = new List<Student>();
            LoadAllStudents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Student s = new Student
            {
                index = textBoxManager_Index.Text,
                lastName = textBoxManager_Surname.Text,
                firstName = textBoxManager_Name.Text,
                city = textBoxManager_City.Text,
                yearOfBirth = Int32.Parse(textBoxManager_YearOfBirth.Text)
            };

            //Tutaj zapytanie do serwera.

            LoadAllStudents();
            LoadListView();

        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            LoadAllStudents();
            students = students.FindAll(s => 
                s.index.Contains(textBoxFilter_Index.Text) && 
                s.lastName.Contains(textBoxFilter_Surname.Text) && 
                s.firstName.Contains(textBoxFilter_Name.Text) && 
                s.city.Contains(textBoxFilter_City.Text) && 
                s.yearOfBirth.ToString().Contains(textBoxFilter_YearOfBirth.Text));
            LoadListView();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            Student s = new Student
            {
                index = textBoxManager_Index.Text,
                lastName = textBoxManager_Surname.Text,
                firstName = textBoxManager_Name.Text,
                city = textBoxManager_City.Text,
                yearOfBirth = Int32.Parse(textBoxManager_YearOfBirth.Text)
            };

            string indexToDelete = textBoxManager_Index.Text;

            //Tutaj zapytanie Delete.
            //Tutaj zapytanie Add.

            LoadAllStudents();
            LoadListView();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string indexToDelete = textBoxManager_Index.Text;

            //Tutaj zapytanie do serwera.

            LoadAllStudents();
            LoadListView();
        }

        private void listView_Students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadAllStudents()
        {
            //Student[] st = client.GetJsonAll();
            //students = st.ToList();

        }

        private void LoadListView() {

            ListViewItem lvi;
            foreach (Student s in students)
            {
                lvi = listView_Students.Items.Add(s.index);
                lvi.SubItems.Add(s.lastName);
                lvi.SubItems.Add(s.firstName);
                lvi.SubItems.Add(s.city);
                lvi.SubItems.Add(s.yearOfBirth.ToString());
            }
            
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
}
