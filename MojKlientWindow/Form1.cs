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
            if(textBoxManager_Index.Text.Length == 0)
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

            string _jsonStudent = JsonParser.WriteFromObject(s);
            string _response = this.client.CreateJsonStudent(_jsonStudent);

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

        private Student tmpStudent;

        private void button_Modify_Click(object sender, EventArgs e)
        {

            Student s = new Student
            {
                index = textBoxManager_Index.Text,
                lastName = textBoxManager_Surname.Text,
                firstName = tmpStudent.firstName, //textBoxManager_Name.Text,
                city = textBoxManager_City.Text,
                yearOfBirth = tmpStudent.yearOfBirth//Int32.Parse(textBoxManager_YearOfBirth.Text)
            };

            
            string indexToUpdate = textBoxManager_Index.Text;

            //Tutaj zapytanie Delete.
            //Tutaj zapytanie Add.
            string _jsonStudent = JsonParser.WriteFromObject(s);
            string _response = this.client.UpdateJsonStudent(indexToUpdate, _jsonStudent);

            LoadAllStudents();
            ReloadListView();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string indexToDelete = textBoxManager_Index.Text;

            //string _response = this.client.DeleteJsonStudent
            //Tutaj zapytanie do serwera.
            string _response = this.client.DeleteJsonStudent(indexToDelete);
            LoadAllStudents();
            ReloadListView();
        }

        private void listView_Students_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Students.SelectedIndices.Count <= 0)
                return;

            ListViewItem lvi = listView_Students.Items[listView_Students.SelectedIndices[0]];
            textBoxManager_Index.Text = lvi.SubItems[0].Text;
            textBoxManager_Surname.Text = lvi.SubItems[1].Text;
            textBoxManager_Name.Text = lvi.SubItems[2].Text;
            textBoxManager_City.Text = lvi.SubItems[3].Text;
            textBoxManager_YearOfBirth.Text = lvi.SubItems[4].Text;

            tmpStudent = new Student
            {
                index = textBoxManager_Index.Text,
                lastName = textBoxManager_Surname.Text,
                firstName = textBoxManager_Name.Text,
                city = textBoxManager_City.Text,
                yearOfBirth = Int32.Parse(textBoxManager_YearOfBirth.Text)
            };
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
