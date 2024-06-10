using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class MovieReviewMovies
    {
        [Key, Column(Order = 0)]
        public int MovieReviewID { get; set; }

        [Key, Column(Order = 1)]
        public int MovieID { get; set; }

        [ForeignKey("MovieReviewID")]
        public virtual MovieReview MovieReview { get; set; }

        [ForeignKey("MovieID")]
        public virtual Movie Movie { get; set; }
    }
}
