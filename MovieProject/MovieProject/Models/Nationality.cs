using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Nationality
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Director> Directors { get; set; }
    }
}
