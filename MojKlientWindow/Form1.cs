using MojWebSerwis;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MojKlientWindow
{
    public partial class Form1 : Form
    {
        private Client client;        
        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
            this.client = new Client();
            this.students = new List<Student>();
            LoadAllStudents();
            ReloadListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(textBoxFilter_Index.Text.Length == 0)
            {
                return;
            }

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
            ReloadListView();

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
            ReloadListView();
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
            ReloadListView();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string indexToDelete = textBoxManager_Index.Text;

            //string _response = this.client.DeleteJsonStudent
            //Tutaj zapytanie do serwera.

            LoadAllStudents();
            ReloadListView();
        }

        private void listView_Students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadAllStudents()
        {            
            string _jsonStudents = this.client.LoadAllJsonStudents();
            this.students = JsonParser.ReadToListOfObjects(_jsonStudents);
        }

        private void ReloadListView()
        {
            listView_Students.Items.Clear();
            foreach(Student s in this.students)
            {
                string[] _row = new string[] { s.index, s.lastName, s.firstName, s.city, s.yearOfBirth.ToString() };
                ListViewItem _listViewItem = new ListViewItem(_row);
                listView_Students.Items.Add(_listViewItem);
            }
        }
    }
}
