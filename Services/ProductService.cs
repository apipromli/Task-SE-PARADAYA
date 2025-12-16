using ECommerce.Models;

namespace ECommerce.Services
{
    public class ProductService : IProductService
    {
        private static List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop Gaming", Price = 15000000, Stock = 10, Description = "Spesifikasi : RAM 32 SSD 1TB" },
            new Product { Id = 2, Name = "Mouse Wireless", Price = 250000, Stock = 50, Description = "Mouse Kekinian" },
        };


        public List<Product> GetAll() => _products;

        public Product? GetById(int id)
            => _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existing = GetById(product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Stock = product.Stock;
                existing.Description = product.Description;
            }
        }

        public void Delete(int id)
        {
            _products.RemoveAll(p => p.Id == id);
        }
    }
}
