using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibraryManagementSystem.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }

        public virtual ICollection<BorrowedBook> BorrowedBooks { get; set; }

    }

}
