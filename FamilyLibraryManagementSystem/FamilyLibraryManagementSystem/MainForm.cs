using FamilyLibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyLibraryManagementSystem
{
    public partial class MainForm : Form
    {

        private readonly LibraryService _libraryService;

        public MainForm(LibraryService libraryService)
        {
            _libraryService = libraryService;
            InitializeComponent();
        }

        private void LoadBooks()
        {
            var books = _libraryService.GetAllBooks().Select(b => new
            {
                b.Title,
                b.Author,
                OwnerName = b.Owner?.Name ?? "N/A",
                OwnerLastName = b.Owner?.LastName ?? "N/A",
                BorrowerName = b.BorrowedBooks.FirstOrDefault()?.BorrowerName ?? "N/A",
                BorrowerLastName = b.BorrowedBooks.FirstOrDefault()?.BorrowerLastName ?? "N/A",
                BorrowedDate = b.BorrowedBooks.FirstOrDefault()?.BorrowedDate.ToString("yyyy-MM-dd") ?? "N/A"
            }).ToList();

            dataGridViewBooks.DataSource = books;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadBooks();
        }

        private void bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrowerLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void OwnerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void shelveNumbernumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var title = bookname.Text;
            var borrowerNameText = borrowerName.Text;
            var borrowerLastNameText = borrowerLastname.Text;
            var ownerNameText = OwnerName.Text;
            var shelveNumber = (int)shelveNumbernumericUpDown.Value;

            // Assuming you have a method in LibraryService to add a book
            _libraryService.AddBook(title, "AuthorName", shelveNumber.ToString(), ownerNameText, "OwnerLastName", borrowerNameText, borrowerLastNameText, DateTime.Now);

            MessageBox.Show("Book added successfully");
            LoadBooks();
        }
    }
}
