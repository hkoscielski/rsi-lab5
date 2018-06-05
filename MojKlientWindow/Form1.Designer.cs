namespace MojKlientWindow
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "228000",
            "Kowalski",
            "Jan",
            "Wrocław",
            "1998"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "231321",
            "Surname",
            "Name",
            "City",
            "Year"}, -1);
            this.listView_Students = new System.Windows.Forms.ListView();
            this.columnHeader_Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BirthYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Filter = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBoxFilter_Name = new System.Windows.Forms.TextBox();
            this.label_Filter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilter_Surname = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Index = new System.Windows.Forms.Label();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.textBoxFilter_Index = new System.Windows.Forms.TextBox();
            this.textBoxFilter_City = new System.Windows.Forms.TextBox();
            this.textBoxFilter_YearOfBirth = new System.Windows.Forms.TextBox();
            this.label_City = new System.Windows.Forms.Label();
            this.label_YearOfBirth = new System.Windows.Forms.Label();
            this.label_Manager = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxManager_Name = new System.Windows.Forms.TextBox();
            this.textBoxManager_Surname = new System.Windows.Forms.TextBox();
            this.textBoxManager_Index = new System.Windows.Forms.TextBox();
            this.textBoxManager_City = new System.Windows.Forms.TextBox();
            this.textBoxManager_YearOfBirth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filterPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Students
            // 
            this.listView_Students.AllowColumnReorder = true;
            this.listView_Students.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Index,
            this.columnHeader_Surname,
            this.columnHeader_Name,
            this.columnHeader_City,
            this.columnHeader_BirthYear});
            this.listView_Students.FullRowSelect = true;
            this.listView_Students.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listView_Students.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView_Students.Location = new System.Drawing.Point(12, 49);
            this.listView_Students.Name = "listView_Students";
            this.listView_Students.Size = new System.Drawing.Size(326, 318);
            this.listView_Students.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_Students.TabIndex = 1;
            this.listView_Students.UseCompatibleStateImageBehavior = false;
            this.listView_Students.View = System.Windows.Forms.View.Details;
            this.listView_Students.SelectedIndexChanged += new System.EventHandler(this.listView_Students_SelectedIndexChanged);
            // 
            // columnHeader_Index
            // 
            this.columnHeader_Index.Text = "Indeks";
            // 
            // columnHeader_Surname
            // 
            this.columnHeader_Surname.Text = "Nazwisko";
            this.columnHeader_Surname.Width = 63;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Imię";
            this.columnHeader_Name.Width = 55;
            // 
            // columnHeader_City
            // 
            this.columnHeader_City.Text = "Miasto";
            // 
            // columnHeader_BirthYear
            // 
            this.columnHeader_BirthYear.Text = "Rok urodzenia";
            this.columnHeader_BirthYear.Width = 77;
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(396, 297);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(75, 32);
            this.button_Filter.TabIndex = 6;
            this.button_Filter.Text = "Filtruj";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(477, 297);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 32);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Dodaj";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(49, 104);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(26, 13);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "Imię";
            // 
            // textBoxFilter_Name
            // 
            this.textBoxFilter_Name.Location = new System.Drawing.Point(14, 120);
            this.textBoxFilter_Name.MaxLength = 20;
            this.textBoxFilter_Name.Name = "textBoxFilter_Name";
            this.textBoxFilter_Name.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter_Name.TabIndex = 3;
            // 
            // label_Filter
            // 
            this.label_Filter.AutoSize = true;
            this.label_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Filter.Location = new System.Drawing.Point(356, 36);
            this.label_Filter.Name = "label_Filter";
            this.label_Filter.Size = new System.Drawing.Size(105, 25);
            this.label_Filter.TabIndex = 6;
            this.label_Filter.Text = "Filtrowanie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(98, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista Studentów";
            // 
            // textBoxFilter_Surname
            // 
            this.textBoxFilter_Surname.Location = new System.Drawing.Point(14, 76);
            this.textBoxFilter_Surname.MaxLength = 20;
            this.textBoxFilter_Surname.Name = "textBoxFilter_Surname";
            this.textBoxFilter_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter_Surname.TabIndex = 2;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(36, 60);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(53, 13);
            this.label_Surname.TabIndex = 8;
            this.label_Surname.Text = "Nazwisko";
            // 
            // label_Index
            // 
            this.label_Index.AutoSize = true;
            this.label_Index.Location = new System.Drawing.Point(43, 18);
            this.label_Index.Name = "label_Index";
            this.label_Index.Size = new System.Drawing.Size(39, 13);
            this.label_Index.TabIndex = 10;
            this.label_Index.Text = "Indeks";
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(477, 335);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(75, 32);
            this.button_Modify.TabIndex = 9;
            this.button_Modify.Text = "Modyfikuj";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(396, 335);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 32);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Usuń";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(344, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 242);
            this.panel1.TabIndex = 28;
            // 
            // filterPanel
            // 
            this.filterPanel.AutoSize = true;
            this.filterPanel.Controls.Add(this.textBoxFilter_Name);
            this.filterPanel.Controls.Add(this.textBoxFilter_Surname);
            this.filterPanel.Controls.Add(this.textBoxFilter_Index);
            this.filterPanel.Controls.Add(this.textBoxFilter_City);
            this.filterPanel.Controls.Add(this.textBoxFilter_YearOfBirth);
            this.filterPanel.Controls.Add(this.label_Name);
            this.filterPanel.Controls.Add(this.label_Surname);
            this.filterPanel.Controls.Add(this.label_Index);
            this.filterPanel.Controls.Add(this.label_City);
            this.filterPanel.Controls.Add(this.label_YearOfBirth);
            this.filterPanel.Location = new System.Drawing.Point(344, 49);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(127, 242);
            this.filterPanel.TabIndex = 28;
            // 
            // textBoxFilter_Index
            // 
            this.textBoxFilter_Index.Location = new System.Drawing.Point(14, 34);
            this.textBoxFilter_Index.MaxLength = 15;
            this.textBoxFilter_Index.Name = "textBoxFilter_Index";
            this.textBoxFilter_Index.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter_Index.TabIndex = 1;
            // 
            // textBoxFilter_City
            // 
            this.textBoxFilter_City.Location = new System.Drawing.Point(14, 162);
            this.textBoxFilter_City.MaxLength = 20;
            this.textBoxFilter_City.Name = "textBoxFilter_City";
            this.textBoxFilter_City.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter_City.TabIndex = 4;
            // 
            // textBoxFilter_YearOfBirth
            // 
            this.textBoxFilter_YearOfBirth.Location = new System.Drawing.Point(14, 205);
            this.textBoxFilter_YearOfBirth.MaxLength = 4;
            this.textBoxFilter_YearOfBirth.Name = "textBoxFilter_YearOfBirth";
            this.textBoxFilter_YearOfBirth.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter_YearOfBirth.TabIndex = 5;
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(43, 146);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(38, 13);
            this.label_City.TabIndex = 12;
            this.label_City.Text = "Miasto";
            // 
            // label_YearOfBirth
            // 
            this.label_YearOfBirth.AutoSize = true;
            this.label_YearOfBirth.Location = new System.Drawing.Point(27, 189);
            this.label_YearOfBirth.Name = "label_YearOfBirth";
            this.label_YearOfBirth.Size = new System.Drawing.Size(76, 13);
            this.label_YearOfBirth.TabIndex = 14;
            this.label_YearOfBirth.Text = "Rok urodzenia";
            // 
            // label_Manager
            // 
            this.label_Manager.AutoSize = true;
            this.label_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Manager.Location = new System.Drawing.Point(481, 37);
            this.label_Manager.Name = "label_Manager";
            this.label_Manager.Size = new System.Drawing.Size(120, 25);
            this.label_Manager.TabIndex = 29;
            this.label_Manager.Text = "Zarządzanie";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.textBoxManager_Name);
            this.panel2.Controls.Add(this.textBoxManager_Surname);
            this.panel2.Controls.Add(this.textBoxManager_Index);
            this.panel2.Controls.Add(this.textBoxManager_City);
            this.panel2.Controls.Add(this.textBoxManager_YearOfBirth);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(477, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 242);
            this.panel2.TabIndex = 30;
            // 
            // textBoxManager_Name
            // 
            this.textBoxManager_Name.Location = new System.Drawing.Point(14, 120);
            this.textBoxManager_Name.MaxLength = 20;
            this.textBoxManager_Name.Name = "textBoxManager_Name";
            this.textBoxManager_Name.Size = new System.Drawing.Size(100, 20);
            this.textBoxManager_Name.TabIndex = 3;
            // 
            // textBoxManager_Surname
            // 
            this.textBoxManager_Surname.Location = new System.Drawing.Point(14, 76);
            this.textBoxManager_Surname.MaxLength = 20;
            this.textBoxManager_Surname.Name = "textBoxManager_Surname";
            this.textBoxManager_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBoxManager_Surname.TabIndex = 2;
            // 
            // textBoxManager_Index
            // 
            this.textBoxManager_Index.Location = new System.Drawing.Point(14, 34);
            this.textBoxManager_Index.MaxLength = 15;
            this.textBoxManager_Index.Name = "textBoxManager_Index";
            this.textBoxManager_Index.Size = new System.Drawing.Size(100, 20);
            this.textBoxManager_Index.TabIndex = 1;
            // 
            // textBoxManager_City
            // 
            this.textBoxManager_City.Location = new System.Drawing.Point(14, 162);
            this.textBoxManager_City.MaxLength = 20;
            this.textBoxManager_City.Name = "textBoxManager_City";
            this.textBoxManager_City.Size = new System.Drawing.Size(100, 20);
            this.textBoxManager_City.TabIndex = 4;
            // 
            // textBoxManager_YearOfBirth
            // 
            this.textBoxManager_YearOfBirth.Location = new System.Drawing.Point(14, 205);
            this.textBoxManager_YearOfBirth.MaxLength = 4;
            this.textBoxManager_YearOfBirth.Name = "textBoxManager_YearOfBirth";
            this.textBoxManager_YearOfBirth.Size = new System.Drawing.Size(100, 20);
            this.textBoxManager_YearOfBirth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nazwisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Indeks";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Miasto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Rok urodzenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 379);
            this.Controls.Add(this.label_Manager);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_Filter);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.listView_Students);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Student Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView_Students;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBoxFilter_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Surname;
        private System.Windows.Forms.ColumnHeader columnHeader_Index;
        private System.Windows.Forms.ColumnHeader columnHeader_City;
        private System.Windows.Forms.ColumnHeader columnHeader_BirthYear;
        private System.Windows.Forms.Label label_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilter_Surname;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Index;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label label_YearOfBirth;
        private System.Windows.Forms.TextBox textBoxFilter_City;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.TextBox textBoxFilter_Index;
        private System.Windows.Forms.TextBox textBoxFilter_YearOfBirth;
        private System.Windows.Forms.Label label_Manager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxManager_Name;
        private System.Windows.Forms.TextBox textBoxManager_Surname;
        private System.Windows.Forms.TextBox textBoxManager_Index;
        private System.Windows.Forms.TextBox textBoxManager_City;
        private System.Windows.Forms.TextBox textBoxManager_YearOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

