using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagmentSystem
{
    public partial class Main : Form
    {
        private DatabaseManager dbManager;

        public Main()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadStudents();
        }
        private void LoadStudents()
        {
            // Retrieve student data from the database
            var students = dbManager.GetStudents();

            // Bind the list of students to the DataGridView
            dataGridViewStudents.DataSource = students;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            LoadStudents(); // Reload student data
        }
    }
}
