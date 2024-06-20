using PetAdaptation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetAdaptation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("petConn")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasRequired(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Pet>()
                .HasRequired(p => p.AddedByUser)
                .WithMany()
                .HasForeignKey(p => p.AddedBy);
        }
    }
}