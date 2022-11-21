using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Sneaker_Shop_Management.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int UserType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
