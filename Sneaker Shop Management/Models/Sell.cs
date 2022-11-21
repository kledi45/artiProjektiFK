using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sneaker_Shop_Management.Models
{
    public class Sell
    {
        [Key]
        public int ID { get; set; }
        public int? IdShoes { get; set; }
        [ForeignKey("IdShoes")]
        public Shoes Shoes { get; set; }
        public int? IdUser { get; set; }
        [ForeignKey("IdUser")]
        public User User { get; set; }
    }
}
