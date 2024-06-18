using FamilyLibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibraryManagementSystem.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=LibraryContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorrowedBook>()
            .HasOptional(bb => bb.Owner)
            .WithMany(o => o.BorrowedBooks)
            .HasForeignKey(bb => bb.OwnerId)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasRequired(b => b.Owner)
                .WithMany(o => o.Books)
                .HasForeignKey(b => b.OwnerId);

            modelBuilder.Entity<BorrowedBook>()
                .HasRequired(bb => bb.Book)
                .WithMany(b => b.BorrowedBooks)
                .HasForeignKey(bb => bb.BookId);


            base.OnModelCreating(modelBuilder);

        }
    }
}
