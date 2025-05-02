using System.ComponentModel.DataAnnotations;

namespace PakMart.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        // Self-referencing for subcategories
        public int? ParentCategoryId { get; set; }

        // Navigation Properties
        public Category ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}