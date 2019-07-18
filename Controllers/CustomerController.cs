using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    public class CustomerController : Controller
    {
        private Context dbContext;
  
        public CustomerController(Context context)
        {
            dbContext = context;
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet("viewClothing")]
        public IActionResult ViewClothing()
        {
            List<Product> AllClothing = dbContext.Products
                .Include(p => p.Categories)
                .ThenInclude(a => a.Category)
                .Where(c => c.Categories.Any(cats => cats.Category.Name == "Clothing"))
                .ToList();

            return View("Clothing", AllClothing);
        }

        [HttpGet("showProduct/{id}")]
        public IActionResult ShowProduct(int id)
        {
            Product prod = dbContext.Products.SingleOrDefault(p => p.ProductId == id);

            return View("Product", prod);
        }
    }
}
