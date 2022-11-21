using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sneaker_Shop_Management.Models;

namespace Sneaker_Shop_Management.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Bid> Bid { get; set; }
        public DbSet<DeliveryType> DeliveryType { get; set; }
        public DbSet<NewsLetter> NewsLetter { get; set; }
        public DbSet<Sell> Sell { get; set; }
        public DbSet<Shoes> Shoes { get; set; }




    }
}
