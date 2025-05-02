using System.ComponentModel.DataAnnotations;

namespace PakMart.Web.ViewModels
{
    public class VendorViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [Required]
        [Display(Name = "Business Address")]
        public string BusinessAddress { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public bool IsApproved { get; set; }
    }
}