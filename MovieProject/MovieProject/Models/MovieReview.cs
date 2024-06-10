using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class MovieReview
    {
        public int ID { get; set; }
        public int MovieID { get; set; }
        public int Score { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Comment { get; set; }
        public Movie Movie { get; set; }
        public ICollection<MovieReviewMovies> MovieReviewMovies { get; set; }
    }
}
