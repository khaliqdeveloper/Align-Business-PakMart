using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace PakMart.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }

        public bool IsActive { get; set; }

        // Foreign Key
        public int VendorId { get; set; }

        // Navigation Property
        public Vendor Vendor { get; set; }
    }
}