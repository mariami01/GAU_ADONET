using FamilyLibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibraryManagementSystem.Data
{
    public class LibraryInitializer : DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var owners = new List<Owner>
            {
                new Owner { Name = "John", LastName = "Doe" },
                new Owner { Name = "Jane", LastName = "Smith" }
            };

            owners.ForEach(o => context.Owners.Add(o));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book { Title = "Book One", Author = "Author One", ShelveNumber = "1", OwnerId = owners[0].Id },
                new Book { Title = "Book Two", Author = "Author Two", ShelveNumber = "1", OwnerId = owners[1].Id }
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var borrowedBooks = new List<BorrowedBook>
            {
                new BorrowedBook { BookId = books[0].Id, BorrowerName = "Borrower One", BorrowerLastName = "Lastname One", BorrowedDate = DateTime.Now },
                new BorrowedBook { BookId = books[1].Id, BorrowerName = "Borrower Two", BorrowerLastName = "Lastname Two", BorrowedDate = DateTime.Now }
            };

            borrowedBooks.ForEach(bb => context.BorrowedBooks.Add(bb));
            context.SaveChanges();
        }
    }
}
