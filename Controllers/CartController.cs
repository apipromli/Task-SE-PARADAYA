using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Services;
using Newtonsoft.Json;

namespace ECommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private const string CART_KEY = "CART";

        public CartController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(GetCart());
        }

        public IActionResult Add(int id)
        {
            var cart = GetCart();
            var product = _productService.GetById(id);

            var item = cart.FirstOrDefault(c => c.Product.Id == id);
            if (item == null)
            {
                cart.Add(new CartItem { Product = product, Quantity = 1 });
            }
            else
            {
                item.Quantity++;
            }

            SaveCart(cart);
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Increase(int id)
        {
            var cart = GetCart();
            cart.First(c => c.Product.Id == id).Quantity++;
            SaveCart(cart);
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Decrease(int id)
        {
            var cart = GetCart();
            var item = cart.First(c => c.Product.Id == id);
            item.Quantity--;
            if (item.Quantity <= 0)
                cart.Remove(item);

            SaveCart(cart);
            return RedirectToAction("Index", "Cart");
        }

        private List<CartItem> GetCart()
        {
            var data = HttpContext.Session.GetString(CART_KEY);
            return data == null
                ? new List<CartItem>()
                : JsonConvert.DeserializeObject<List<CartItem>>(data);
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetString(CART_KEY, JsonConvert.SerializeObject(cart));
        }
    }
}
