using MojWebSerwis;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MojKlientWindow
{
    /// <summary>
    /// Klasa stanowiąca interfejs okienkowy klienta. 
    /// Zawiera metody aktywowane podczas interakcji z kontrolkami w interfejsie graficznym.
    /// Cała aplikacja zapewnia bazę studentów, z możliwością ich Filtrowania, Dodawania, Usuwania, Modyfikowania.
    /// Zapewnia również wykorzystanie klasy klienta, która łączy się z serwisem.
    /// Autor: 228172. Hubert Kościelski.
    /// </summary>
    public partial class Form1 : Form
    {
        private Client client;        
        private List<Student> students;
        private Student tmpStudent;

        /// <summary>
        /// Konstruktor klasy Form1. Zapewnia inicjalizację komponentów interfejsu graficznego.
        /// Inicjalizuje również nowe instancję klasy Client i Listy Studentów.
        /// Dodatkowo ładuje pełna listę studentów, która będzie widoczna po uruchomieniu aplikacji.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.client = new Client();
            this.students = new List<Student>();
            LoadAllStudents();
            ReloadListView();
        }

        /// <summary>
        /// Metoda wywoływana w momencie wciśnięcia przycisku "Dodaj" na interfejsie graficznym. 
        /// Pobiera dane z kontrolek znajdujących się pod grupą "Zarządzanie". 
        /// Następnie z podanych danych tworzy nową instancję Studenta. Wykorzystuje klasę JsonParser do konwersji obiektu Studenta do postaci JSON.
        /// Następnie wywołuje odpowiednią metodę klasy Client, która wysyła obiekt w formacie JSON do serwisu.
        /// Po wszystkim metoda pobiera nową listę studentów i odświeża kontrolkę wyświetlającą listę Studentów.
        /// </summary>
        /// <param name="sender">object Argument niewykorzystywany.</param>
        /// <param name="e">EventArgs Argument niewykorzystywany</param>
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

            //Zapytanie do serwisu.
            string _jsonStudent = JsonParser.WriteFromObject(s);
            string _response = this.client.CreateJsonStudent(_jsonStudent);

            LoadAllStudents();
            ReloadListView();
        }

        /// <summary>
        /// Metoda wywoływana w momencie wciśnięcia przycisku "Filtruj" na interfejsie graficznym. 
        /// Pobiera dane z kontrolek znajdujących się pod grupą "Filtrowanie". 
        /// Ładuje pełną listę studentów, następnie dokonuje na nich Filtrowania poprzez wykorzystanie metody Contains na każdej z właściwości Studenta, która zostanie porównana z odpowiednią kontrolką spod grupy "Filtrowanie".
        /// Po dokonaniu Filtrowania, metoda odświeża kontrolkę wyświetlającą listę Studentów.
        /// </summary>
        /// <param name="sender">object Argument niewykorzystywany.</param>
        /// <param name="e">EventArgs Argument niewykorzystywany</param>
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

        /// <summary>
        /// Metoda wywoływana w momencie wciśnięcia przycisku "Modyfikuj" na interfejsie graficznym. 
        /// Pobiera dane z kontrolek znajdujących się pod grupą "Zarządzanie". 
        /// Modyfikuje studenta o podanym Indeksie. Ignoruje zmianę Imienia i Roku Urodzenia. Możliwa jest jedynie zmiana Nazwiska i Miasta danego Studenta.
        /// W celu modyfikacji tworzy nową instancję Studenta na podstawie poprzedniej instancji. 
        /// Tak powstały obiekt Studenta zamienia na obiekt w formacie JSON, który jest następnie wykorzystywany przez instancję Client do wykonania odpowiedniego połączenia z serwisem.
        /// Po zmodyfikowaniu metoda pobiera nową listę studentów i odświeża kontrolkę wyświetlającą listę Studentów.
        /// </summary>
        /// <param name="sender">object Argument niewykorzystywany.</param>
        /// <param name="e">EventArgs Argument niewykorzystywany</param>
        private void button_Modify_Click(object sender, EventArgs e)
        {

            Student s = new Student
            {
                index = textBoxManager_Index.Text,
                lastName = textBoxManager_Surname.Text,
                firstName = tmpStudent.firstName,       //ignoruje
                city = textBoxManager_City.Text,
                yearOfBirth = tmpStudent.yearOfBirth    //ignoruje
            };

            
            string indexToUpdate = textBoxManager_Index.Text;

            //Zapytanie do serwisu.
            string _jsonStudent = JsonParser.WriteFromObject(s);
            string _response = this.client.UpdateJsonStudent(indexToUpdate, _jsonStudent);

            LoadAllStudents();
            ReloadListView();
        }

        /// <summary>
        /// Metoda wywoływana w momencie wciśnięcia przycisku "Usuń" na interfejsie graficznym. 
        /// Pobiera dane z kontrolek znajdujących się pod grupą "Zarządzanie". 
        /// Usuwa studenta o podanym Indeksie. W tym celu wywołuje odpowiednią metodę za pomocą instancji Client.
        /// Po dokonaniu usunięcia metoda pobiera nową listę studentów i odświeża kontrolkę wyświetlającą listę Studentów.
        /// </summary>
        /// <param name="sender">object Argument niewykorzystywany.</param>
        /// <param name="e">EventArgs Argument niewykorzystywany</param>
        private void button_Delete_Click(object sender, EventArgs e)
        {
            string indexToDelete = textBoxManager_Index.Text;

            //Zapytanie do serwisu.
            string _response = this.client.DeleteJsonStudent(indexToDelete);

            LoadAllStudents();
            ReloadListView();
        }

        /// <summary>
        /// Metoda wywoływana w momencie zmiany wybranego Studenta na liście studentów z interfejsu graficznego. 
        /// Pobiera dane wybranego Studenta i wstawia je do kontrolek znajdujących się pod grupą "Zarządzanie". 
        /// Takie wybieranie Studentów ułatwia operacje Usuwania lub Modyfikowania poprzez wykluczenie konieczności ręcznego wpisywania danych.
        /// </summary>
        /// <param name="sender">object Argument niewykorzystywany.</param>
        /// <param name="e">EventArgs Argument niewykorzystywany</param>
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

        /// <summary>
        /// Metoda pomocnicza pobierająca instancją Client całą listę studentów i przechowująca ją jako zmienną: Listę Studentów klasy Form1.
        /// </summary>
        private void LoadAllStudents()
        {
            //Zapytanie do serwisu.
            string _jsonStudents = this.client.LoadAllJsonStudents();
            this.students = JsonParser.ReadToListOfObjects(_jsonStudents);
        }

        /// <summary>
        /// Metoda pomocnicza wywołująca ponowne załadowanie obecnie przechowywanej jako zmienna Listy Studentów w klasie Form1, do listy studentów znajdującej się w interfejsie graficznym.
        /// </summary>
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
