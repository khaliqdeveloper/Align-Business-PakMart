using System.ComponentModel.DataAnnotations;

namespace PakMart.Domain.Entities
{
    public class Vendor
    {
        public int Id { get; set; }

        [Required]
        public string BusinessName { get; set; }

        [Required]
        public string BusinessAddress { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public bool IsApproved { get; set; }

        // Navigation Property
        public ICollection<Product> Products { get; set; }
    }
}