using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakMart.Domain.Entities
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public int? PictureId { get; set; }
        public Picture Picture { get; set; }

        [Display(Name = "Manufacturer Name")]
        public string ManufacturerName { get; set; }

        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

        public bool Publish { get; set; }

        public string? FullDesc { get; set; }

        public ICollection<ProductManufacturerMapping> ProductManufacturers { get; set; }
    }
}
