using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Director
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
