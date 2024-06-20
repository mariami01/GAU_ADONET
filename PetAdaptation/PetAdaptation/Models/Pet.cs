using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdaptation.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }

        [MaxLength(50)]
        public string Color { get; set; }

        public int Age { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string Characteristic { get; set; }

        [Required]
        [MaxLength(50)]
        public string Species { get; set; }

        public float Weight { get; set; }

        [MaxLength(100)]
        public string Location { get; set; }

        [ForeignKey("AddedByUser")]
        public int AddedBy { get; set; }
        public User AddedByUser { get; set; }

        public bool IsAdopted { get; set; } = false;

        public DateTime AddedDate { get; set; } = DateTime.UtcNow;
    }
}