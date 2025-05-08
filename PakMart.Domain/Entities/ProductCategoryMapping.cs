
using System.ComponentModel.DataAnnotations;

namespace PakMart.Domain.Entities
{
    public class ProductCategoryMapping
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
