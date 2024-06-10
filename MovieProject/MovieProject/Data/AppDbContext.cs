using MovieProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=MovieConnection") { }

        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieReview> MovieReviews { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasRequired(m => m.Director)
                .WithMany(d => d.Movies)
                .HasForeignKey(m => m.DirectorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasRequired(m => m.MovieCategory)
                .WithMany(c => c.Movies)
                .HasForeignKey(m => m.MovieCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieReview>()
                .HasRequired(r => r.Movie)
                .WithMany(m => m.MovieReviews)
                .HasForeignKey(r => r.MovieID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieReviewMovies>()
                .HasRequired(mrm => mrm.MovieReview)
                .WithMany(mr => mr.MovieReviewMovies)
                .HasForeignKey(mrm => mrm.MovieReviewID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieReviewMovies>()
                .HasRequired(mrm => mrm.Movie)
                .WithMany(m => m.MovieReviewMovies)
                .HasForeignKey(mrm => mrm.MovieID)
                .WillCascadeOnDelete(false);
        }
    }
}
