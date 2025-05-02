using System.ComponentModel.DataAnnotations;

namespace PakMart.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentCategoryId { get; set; }
    }
}