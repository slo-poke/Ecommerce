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
    public class HomeController : Controller
    {
        private Context dbContext;

        public HomeController(Context context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("Dashboard");
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.Products = dbContext.Products.OrderBy(p => p.CreatedAt).Take(5).ToList<Product>();
            ViewBag.Orders = dbContext.Orders.OrderBy(o => o.CreatedAt).Take(3).ToList<Order>();
            ViewBag.Customers = dbContext.Customers.OrderBy(c => c.CreatedAt).Take(3).ToList<Customer>();

            return View("Index");
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            Product prod = new Product();

            ViewBag.AllProducts = dbContext.Products.Take(15).ToList<Product>();

            return View("Products", prod);
        }

        [HttpPost("/products/add")]
        public IActionResult AddProduct(Product newProd)
        {
            if (ModelState.IsValid)
            {
                newProd.CreatedAt = DateTime.Now;
                newProd.UpdatedAt = DateTime.Now;
                dbContext.Products.Add(newProd);
                dbContext.SaveChanges();

                return RedirectToAction("Products");
            }

            Product prod = new Product();

            ViewBag.AllProducts = dbContext.Products.Take(15).ToList<Product>();

            return View("Products");
        }

        [HttpGet("orders")]
        public IActionResult Orders()
        {
            Order newOrder = new Order();

            ViewBag.AllCustomers = dbContext.Customers.ToList<Customer>();
            ViewBag.AllProducts = dbContext.Products.ToList<Product>();
            ViewBag.AllOrders = dbContext.Orders
                .Include(o => o.Customer)
                .Include(o => o.Product)
                .ToList<Order>();

            return View("Orders", newOrder);
        }

        [HttpPost("orders/add")]
        public IActionResult AddOrder(Order newOrder)
        {
            if(ModelState.IsValid)
            {

                newOrder.Product = dbContext.Products.SingleOrDefault(p => p.ProductId == newOrder.ProductId);

                if (newOrder.Quantity <= newOrder.Product.Quantity && newOrder.Quantity > 0)
                {
                    newOrder.CreatedAt = DateTime.Now;
                    newOrder.UpdatedAt = DateTime.Now;
                    dbContext.Orders.Add(newOrder);
                    dbContext.SaveChanges();

                    return RedirectToAction("Orders");
                }

                ModelState.AddModelError("Quantity", "Cannot order more product than what is available");
            }

            Order orderModel = new Order();

            ViewBag.AllCustomers = dbContext.Customers.ToList<Customer>();
            ViewBag.AllProducts = dbContext.Products.ToList<Product>();
            ViewBag.AllOrders = dbContext.Orders
                .Include(o => o.Customer)
                .Include(o => o.Product)
                .ToList<Order>();

            return View("Orders", orderModel);
        }

        [HttpGet("customers")]
        public IActionResult Customers()
        {
            Customer newCust = new Customer();

            ViewBag.AllCustomers = dbContext.Customers.ToList<Customer>();

            return View("Customers", newCust);
        }

        [HttpPost("customers/add")]
        public IActionResult AddCustomer(Customer newCust)
        {
            if(ModelState.IsValid)
            {
                Customer cust = dbContext.Customers.SingleOrDefault(c => c.CustomerId == newCust.CustomerId);

                if(cust == null)
                {
                    newCust.CreatedAt = DateTime.Now;
                    newCust.UpdatedAt = DateTime.Now;
                    dbContext.Customers.Add(newCust);
                    dbContext.SaveChanges();

                    return RedirectToAction("Customers");
                }

                ModelState.AddModelError("Name", "This name already exists.");
            }

            Customer newCustModel = new Customer();

            ViewBag.AllCustomers = dbContext.Customers.ToList<Customer>();

            return View("Customers", newCustModel);
        }

        [HttpGet("remove/{id}")]
        public IActionResult Remove(int id)
        {
            Customer custToRemove = dbContext.Customers.SingleOrDefault(c => c.CustomerId == id);

            dbContext.Customers.Remove(custToRemove);
            dbContext.SaveChanges();

            return RedirectToAction("Customers");
        }

        [HttpPost("search/products")]
        public IActionResult SearchProducts(string Search)
        {
            List<Product> prods = dbContext.Products.Where(p => p.Name.Contains(Search)).ToList<Product>();

            if(prods == null)
            {
                ViewBag.ErrorMessage = "No results match your search";
            }

            ViewBag.SearchProducts = prods;
            Product newProd = new Product();

            ViewBag.AllProducts = dbContext.Products.Take(15).ToList<Product>();

            return View("Products", newProd);
        }

        [HttpPost("search/customers")]
        public IActionResult SearchCustomers(string Search)
        {
            List<Customer> custs = dbContext.Customers.Where(c => c.Name.Contains(Search)).ToList<Customer>();

            if(custs == null)
            {
                ViewBag.ErrorMessage = "No results match your search";
            }

            ViewBag.SearchCustomers = custs;

            Customer newCust = new Customer();

            ViewBag.AllCustomers = dbContext.Customers.ToList<Customer>();

            return View("Customers", newCust);
        }
    }
}
