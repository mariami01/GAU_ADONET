using FamilyLibraryManagementSystem.Data;
using FamilyLibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibraryManagementSystem.Services
{
    public class LibraryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LibraryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddBook(string title, string author, string shelveNumber, string ownerName, string ownerLastName, string borrowerName, string borrowerLastName, DateTime borrowedDate)
        {
            var owner = new Owner { Name = ownerName, LastName = ownerLastName };
            _unitOfWork.Owners.Add(owner);
            _unitOfWork.Complete();

            var book = new Book { Title = title, Author = author, ShelveNumber = shelveNumber, OwnerId = owner.Id };
            _unitOfWork.Books.Add(book);
            _unitOfWork.Complete();

            var borrowedBook = new BorrowedBook { BookId = book.Id, BorrowerName = borrowerName, BorrowerLastName = borrowerLastName, BorrowedDate = borrowedDate };
            _unitOfWork.BorrowedBooks.Add(borrowedBook);
            _unitOfWork.Complete();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _unitOfWork.Books.GetAll();
        }

        public bool UpdateBook(int bookId, string title, string author, string shelveNumber, string ownerName, string ownerLastName)
        {
            var book = _unitOfWork.Books.GetById(bookId);
            if (book != null)
            {
                var owner = book.Owner;
                owner.Name = ownerName;
                owner.LastName = ownerLastName;

                book.Title = title;
                book.Author = author;
                book.ShelveNumber = shelveNumber;

                _unitOfWork.Books.Update(book);
                _unitOfWork.Complete();
                return true;
            }
            return false;
        }

        public bool DeleteBook(int bookId)
        {
            var book = _unitOfWork.Books.GetById(bookId);
            if (book != null)
            {
                _unitOfWork.Books.Delete(book);
                _unitOfWork.Complete();
                return true;
            }
            return false;
        }
    }
}
