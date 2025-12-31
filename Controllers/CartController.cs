using Microsoft.AspNetCore.Mvc;
using TechozStore.Models;
using TechozStore.Extensions;

namespace TechozStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
            return View(cart);
        }

        public IActionResult AddToCart(int productId, string name, decimal price)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
            
            var existingItem = cart.FirstOrDefault(i => i.Product.Id == productId);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Add(new CartItem
                {
                    Product = new Product { Id = productId, Name = name, Price = price },
                    Quantity = 1
                });
            }

            HttpContext.Session.Set("Cart", cart);
            return RedirectToAction("Index"); // Or redirect to Home/Index depending on UX
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(i => i.Product.Id == productId);
            if (item != null)
            {
                cart.Remove(item);
            }
            HttpContext.Session.Set("Cart", cart);
            return RedirectToAction("Index");
        }
        
        public IActionResult ClearCart()
        {
             HttpContext.Session.Remove("Cart");
             return RedirectToAction("Index");
        }
    }
}
