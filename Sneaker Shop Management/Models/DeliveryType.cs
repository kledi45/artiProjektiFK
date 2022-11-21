using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sneaker_Shop_Management.Models
{
    public class DeliveryType
    {
        [Key]
        public int ID { get; set; }
        public int? IdShoes { get; set; }
        [ForeignKey("IdShoes")]
        public Shoes Shoes { get; set; }
        public int Type1 { get; set; }
        public int Type2 { get; set; }
        public int Type3 { get; set; }

    }
}
