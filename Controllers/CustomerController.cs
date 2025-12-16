using Microsoft.AspNetCore.Mvc;
using ECommerce.Services;

namespace ECommerce.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IProductService _productService;

        public CustomerController(IProductService productService)
        {
            _productService = productService;
        }

        // Landing Page
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }
    }
}
