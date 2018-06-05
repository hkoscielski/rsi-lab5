using MojWebSerwis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojKlientWindow
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        private ServiceReference1.RestService1Client client;

        private const string BASE_URI = "http://192.168.43.82:3000/Service1.svc";
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
            client = new ServiceReference1.RestService1Client();
            students = new List<Student>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {

        }

        private void button_Filter_Click(object sender, EventArgs e)
        {

        }

        private void button_Modify_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void listView_Students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadAllStudents()
        {
            students = client.GetJsonAll().ToList();
        }
    }
}
