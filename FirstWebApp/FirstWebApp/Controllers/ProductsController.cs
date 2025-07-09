using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApp.Controllers
{
    public class ProductsController : Controller
    {
        // Action يعرض قائمة المنتجات
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Bluetooth Headphones", Price = 199.99m },
                new Product { Id = 2, Name = "Fast Charger", Price = 89.50m },
                new Product { Id = 3, Name = "Smart Watch", Price = 499.00m }
            };

            return View(products);
        }

        // Action يعرض تفاصيل المنتج حسب Id
        public IActionResult Details(int id)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Bluetooth Headphones", Price = 199.99m },
                new Product { Id = 2, Name = "Fast Charger", Price = 89.50m },
                new Product { Id = 3, Name = "Smart Watch", Price = 499.00m }
            };

            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }

        // Action يعرض منتج عشوائي
        public IActionResult Random()
        {
            var product = new Product
            {
                Id = 4,
                Name = "Power Bank",
                Price = 129.00m
            };

            return View(product);
        }
    }
}
