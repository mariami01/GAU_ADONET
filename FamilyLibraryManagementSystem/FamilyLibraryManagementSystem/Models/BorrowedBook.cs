using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibraryManagementSystem.Models
{
    public class BorrowedBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BorrowerName { get; set; }
        public string BorrowerLastName { get; set; }
        public DateTime BorrowedDate { get; set; }
        public Book Book { get; set; }

        public int? OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
    }

}
