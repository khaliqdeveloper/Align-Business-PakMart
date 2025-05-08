using System.ComponentModel.DataAnnotations;

namespace PakMart.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }
        public string SKU { get; set; }

        public bool Publish { get; set; }
        public bool Returnable { get; set; }

        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }

        public int? RemainingDays { get; set; }

        public decimal? CostPrice { get; set; }
        public decimal? SalesTax { get; set; }
        public decimal? Freight { get; set; }

        public int? OpeningStock { get; set; }
        public int? MinimumStock { get; set; }

        public int? Warehouse { get; set; }
        public int? Aisle { get; set; }
        public int? Rack { get; set; }
        public int? Bin { get; set; }

        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Diameter { get; set; }
        public decimal? Weight { get; set; }

        public string? ShortDescription { get; set; }
        public string? FullDescription { get; set; }

        public ICollection<ProductCategoryMapping> ProductCategories { get; set; }
        public ICollection<ProductManufacturerMapping> ProductManufacturers { get; set; }
        public ICollection<ProductPictureMapping> ProductPictures { get; set; }
    }
}