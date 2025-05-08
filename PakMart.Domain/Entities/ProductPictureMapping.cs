
using System.ComponentModel.DataAnnotations;

namespace PakMart.Domain.Entities
{
    public class ProductPictureMapping
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int PictureId { get; set; }
        public Picture Picture { get; set; }
    }
}
