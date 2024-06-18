using FamilyLibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibraryManagementSystem.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Book> Books { get; }
        IRepository<Owner> Owners { get; }
        IRepository<BorrowedBook> BorrowedBooks { get; }
        int Complete();
    }

}