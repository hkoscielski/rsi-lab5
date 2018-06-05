//using MojWebSerwis;
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

namespace MojKlientWindow
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        //private ServiceReference1.RestService1Client client;
        private RestService1Client client;

        private const string BASE_URI = "http://192.168.0.7:3000/Service1.svc";
        private const string FORMAT = "json";
        private const string JSON_CONTENT_TYPE = "application/json";

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
            WebHttpBinding binding = new WebHttpBinding();
            EndpointAddress address = new EndpointAddress(BASE_URI);
            //client = new ServiceReference1.RestService1Client(binding, address);
            //client = new RestService1Client();// binding, address);
            client = new RestService1Client();
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
            Student[] st = client.GetJsonAll();
            students = st.ToList();
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
    }
}
