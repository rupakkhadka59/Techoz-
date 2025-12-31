using Microsoft.AspNetCore.Mvc;
using TechozStore.Models;
using System.Collections.Generic;

namespace TechozStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "MacBook Pro 16", Price = 2499, Category = "Laptop", ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80", Description = "Powerful performance with M2 chip." },
                new Product { Id = 2, Name = "Dell XPS 15", Price = 1899, Category = "Laptop", ImageUrl = "https://images.unsplash.com/photo-1593642632823-8f78536788c6?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80", Description = "Stunning 4K OLED display." },
                new Product { Id = 3, Name = "HP Spectre x360", Price = 1599, Category = "Laptop", ImageUrl = "https://images.unsplash.com/photo-1544731612-de7f96afe55f?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80", Description = "Convertible laptop for versatility." },
                new Product { Id = 4, Name = "Asus ROG Zephyrus", Price = 2199, Category = "Gaming", ImageUrl = "https://images.unsplash.com/photo-1542393545-facac42e67ee?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80", Description = "High refresh rate for gaming." },
                new Product { Id = 5, Name = "Lenovo ThinkPad X1", Price = 1799, Category = "Business", ImageUrl = "https://images.unsplash.com/photo-1588872657578-a3d8919f6b01?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80", Description = "Legendary keyboard and durability." },
                new Product { Id = 6, Name = "Microsoft Surface Laptop", Price = 1299, Category = "Laptop", ImageUrl = "https://images.unsplash.com/photo-1587614382346-4ec70e388b28?ixlib=rb-1.2.1&auto=format&fit=crop&w=1000&q=80", Description = "Sleek design and touchscreen." }
            };
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
