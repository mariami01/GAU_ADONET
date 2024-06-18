using FamilyLibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibraryManagementSystem.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _context;

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
            Books = new Repository<Book>(_context);
            Owners = new Repository<Owner>(_context);
            BorrowedBooks = new Repository<BorrowedBook>(_context);
        }

        public IRepository<Book> Books { get; private set; }
        public IRepository<Owner> Owners { get; private set; }
        public IRepository<BorrowedBook> BorrowedBooks { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
