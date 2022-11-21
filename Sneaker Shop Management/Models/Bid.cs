using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sneaker_Shop_Management.Models
{
    public class Bid
    {
        [Key]
        public int ID { get; set; }
        public int? IdSell { get; set; }
        [ForeignKey("IdSell")]
        public Sell Sell { get; set; }
    }
}
