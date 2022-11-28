using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Sneaker_Shop_Management.Data;
using Sneaker_Shop_Management.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneaker_Shop_Management.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult MyProducts()
        {
            var shoes = _context.Shoes.ToList();
            return View(shoes);
        }

       
    }
}
