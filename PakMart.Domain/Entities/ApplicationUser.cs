using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PakMart.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CompanyName { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string CountryCode { get; set; }
        public string Role { get; set; }
    }
}
