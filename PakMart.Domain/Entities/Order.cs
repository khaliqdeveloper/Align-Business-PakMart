using System.ComponentModel.DataAnnotations;

namespace PakMart.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalAmount { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        [Required]
        public string ShippingAddress { get; set; }

        // Navigation Property
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}