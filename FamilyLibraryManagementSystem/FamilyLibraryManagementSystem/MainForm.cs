using FamilyLibraryManagementSystem.Models;
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
        private int _selectedBookId;


        public MainForm(LibraryService libraryService)
        {
            _libraryService = libraryService;
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            var books = _libraryService.GetAllBooks().Select(b => new
            {
                b.Title,
                b.Author,
                OwnerName = b.Owner?.Name ?? "N/A",
                OwnerLastName = b.Owner?.LastName ?? "N/A",
               // BorrowerName = b.BorrowedBooks.FirstOrDefault()?.BorrowerName ?? "N/A",
              //  BorrowerLastName = b.BorrowedBooks.FirstOrDefault()?.BorrowerLastName ?? "N/A",
               // BorrowedDate = b.BorrowedBooks.FirstOrDefault()?.BorrowedDate.ToString("yyyy-MM-dd") ?? "N/A"
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

            _libraryService.AddBook(title, "AuthorName", shelveNumber.ToString(), ownerNameText, "OwnerLastName", borrowerNameText, borrowerLastNameText, DateTime.Now);

            MessageBox.Show("Book added successfully");
            LoadBooks();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var success = _libraryService.DeleteBook(_selectedBookId);

            if (success)
            {
                MessageBox.Show("Book deleted successfully");
            }
            else
            {
                MessageBox.Show("An issue occurred while deleting the book");
            }
            LoadBooks();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            var title = bookname.Text;
            var ownerNameText = OwnerName.Text;
            var shelveNumber = (int)shelveNumbernumericUpDown.Value;

            var success = _libraryService.UpdateBook(_selectedBookId, title, "AuthorName", shelveNumber.ToString(), ownerNameText, "OwnerLastName");

            if (success)
            {
                MessageBox.Show("Book updated successfully");
            }
            else
            {
                MessageBox.Show("An issue occurred while updating the book");
            }
            LoadBooks();
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                var row = dataGridViewBooks.SelectedRows[0];
                _selectedBookId = Convert.ToInt32(row.Cells["Id"].Value);
                bookname.Text = row.Cells["Title"].Value.ToString();
                OwnerName.Text = row.Cells["OwnerName"].Value.ToString();
                borrowerName.Text = row.Cells["BorrowerName"].Value.ToString();
                borrowerLastname.Text = row.Cells["BorrowerLastName"].Value.ToString();
            }
        }
    }
}
