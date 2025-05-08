using System.ComponentModel.DataAnnotations;

namespace PakMart.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public int? PictureId { get; set; }
        public Picture Picture { get; set; }

        public string CategoryName { get; set; }

        public bool Publish { get; set; }

        public bool ShowOnHomePage { get; set; }

        public bool IncludeInTopMenu { get; set; }

        public int DisplayOrder { get; set; }

        public string? FullDesc { get; set; }

        public ICollection<ProductCategoryMapping> ProductCategories { get; set; }
    }
}