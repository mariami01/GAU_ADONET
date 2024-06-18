using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int OwnerId { get; set; }
        public string ShelveNumber { get; set; }
        public Owner Owner { get; set; }
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }
    }

}
