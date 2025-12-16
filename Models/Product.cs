using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nama produk wajib diisi")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1000, 100000000)]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
