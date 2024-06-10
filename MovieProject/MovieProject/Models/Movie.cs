using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public int MovieCategoryID { get; set; }
        public string Title { get; set; }
        public int DirectorID { get; set; }
        public int DurationInMinutes { get; set; }
        public int? YearOfRelease { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public Director Director { get; set; }
        public ICollection<MovieReview> MovieReviews { get; set; }
        public ICollection<MovieReviewMovies> MovieReviewMovies { get; set; }

    }
}
