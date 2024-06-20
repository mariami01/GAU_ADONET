using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdaptation.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public string AuthToken { get; set; }
        public DateTime? TokenExpiry { get; set; }
    }
}