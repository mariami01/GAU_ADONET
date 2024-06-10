using MovieProject.Data;
using MovieProject.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MovieProject
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            //dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                movieName.Text = selectedRow.Cells["Title"].Value.ToString();
                dirName.Text = selectedRow.Cells["DirectorName"].Value.ToString();
                dirLastname.Text = selectedRow.Cells["DirectorLastName"].Value.ToString();
                duration.Text = selectedRow.Cells["DurationInMinutes"].Value.ToString();
                releaseDate.Value = Convert.ToDateTime(selectedRow.Cells["YearOfRelease"].Value);
                category.Text = selectedRow.Cells["CategoryName"].Value.ToString();
                score.Value = Convert.ToDecimal(selectedRow.Cells["Score"].Value ?? 0);
                reviewDate.Value = Convert.ToDateTime(selectedRow.Cells["ReviewDate"].Value ?? DateTime.Today);
                comment.Text = selectedRow.Cells["Comment"].Value.ToString();
                Nationality.Text = selectedRow.Cells["Nationality"].Value.ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(duration.Text, out int durationValue))
                {
                    MessageBox.Show("Invalid duration. Please enter a valid number.");
                    return;
                }

                DateTime releaseDateValue = releaseDate.Value;
                DateTime reviewDateValue = reviewDate.Value;
                DateTime today = DateTime.Today;

                if (releaseDateValue > today)
                {
                    MessageBox.Show("Release date cannot be in the future.");
                    return;
                }

                if (reviewDateValue > today)
                {
                    MessageBox.Show("Review date cannot be in the future.");
                    return;
                }

                if (reviewDateValue < releaseDateValue)
                {
                    MessageBox.Show("Review date cannot be before the release date.");
                    return;
                }

                var newMovie = new Movie
                {
                    Title = movieName.Text,
                    Director = new Director
                    {
                        FirstName = dirName.Text,
                        LastName = dirLastname.Text,
                        Nationality = new Nationality { Name = Nationality.Text }
                    },
                    DurationInMinutes = durationValue,
                    YearOfRelease = releaseDateValue.Year,
                    MovieCategory = new MovieCategory { Name = category.Text },
                    MovieReviews = new System.Collections.Generic.List<MovieReview>
            {
                new MovieReview
                {
                    Score = (int)score.Value,
                    ReviewDate = reviewDateValue,
                    Comment = comment.Text
                }
            }
                };

                _context.Movies.Add(newMovie);
                _context.SaveChanges();
                LoadMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding movie: {ex.Message}");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int movieId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MovieID"].Value);
                    var movie = _context.Movies.Include(m => m.MovieReviews).FirstOrDefault(m => m.ID == movieId);

                    if (movie != null)
                    {
                        _context.Movies.Remove(movie);
                        _context.SaveChanges();
                        LoadMovies();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting movie: {ex.Message}");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
             try
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            int movieId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MovieID"].Value);
            var movie = _context.Movies.Include(m => m.Director)
                                       .Include(m => m.MovieCategory)
                                       .Include(m => m.MovieReviews)
                                       .FirstOrDefault(m => m.ID == movieId);

            if (movie != null)
            {
                // Validate duration
                if (!int.TryParse(duration.Text, out int durationValue))
                {
                    MessageBox.Show("Invalid duration. Please enter a valid number.");
                    return;
                }

                // Validate dates
                DateTime releaseDateValue = releaseDate.Value;
                DateTime reviewDateValue = reviewDate.Value;
                DateTime today = DateTime.Today;

                if (releaseDateValue > today)
                {
                    MessageBox.Show("Release date cannot be in the future.");
                    return;
                }

                if (reviewDateValue > today)
                {
                    MessageBox.Show("Review date cannot be in the future.");
                    return;
                }

                if (reviewDateValue < releaseDateValue)
                {
                    MessageBox.Show("Review date cannot be before the release date.");
                    return;
                }

                // Update movie details
                movie.Title = movieName.Text;
                movie.Director.FirstName = dirName.Text;
                movie.Director.LastName = dirLastname.Text;
                movie.DurationInMinutes = durationValue;
                movie.YearOfRelease = releaseDateValue.Year;
                movie.MovieCategory.Name = category.Text;

                // Update review details if exists
                var review = movie.MovieReviews.FirstOrDefault();
                if (review != null)
                {
                    review.Score = (int)score.Value;
                    review.ReviewDate = reviewDateValue;
                    review.Comment = comment.Text;
                }

                _context.SaveChanges();
                LoadMovies();
            }
        }
        else
        {
            MessageBox.Show("No movie selected. Please select a movie to update.");
        }
    }
    catch (FormatException fe)
    {
        MessageBox.Show($"Input format is incorrect: {fe.Message}");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error updating movie: {ex.Message}");
    }
        }
        private void LoadMovies()
        {
            var movies = _context.Movies
                                  .Include(m => m.Director)
                                  .Include(m => m.MovieCategory)
                                  .Include(m => m.Director.Nationality)
                                  .Include(m => m.MovieReviews)
                                  .Select(m => new
                                  {
                                      MovieID = m.ID,
                                      Title = m.Title,
                                      DirectorName = m.Director.FirstName,
                                      DirectorLastName = m.Director.LastName,
                                      Nationality = m.Director.Nationality.Name,
                                      DurationInMinutes = m.DurationInMinutes,
                                      YearOfRelease = m.YearOfRelease,
                                      Score = (int?)m.MovieReviews.FirstOrDefault().Score,
                                      ReviewDate = (DateTime?)m.MovieReviews.FirstOrDefault().ReviewDate,
                                      CategoryName = m.MovieCategory.Name,
                                      Comment = m.MovieReviews.FirstOrDefault().Comment
                                  })
                                  .ToList();
            dataGridView1.DataSource = movies;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void dirLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void MainForm_Load_2(object sender, EventArgs e)
        {

        }
    }
}
