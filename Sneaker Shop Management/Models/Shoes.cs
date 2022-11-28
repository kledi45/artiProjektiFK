using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Sneaker_Shop_Management.Models
{
    public class Shoes
    {
        [Key]
        public int ID { get; set; }

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [Required]
        public int BuyPrice { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public double Size { get; set; }
        [Required]
        public string Type { get; set; }
        
        public double? BidPrice { get; set; }
        public string? Description { get; set; }

    }
}
