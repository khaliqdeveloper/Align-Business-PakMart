using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PakMart.Domain.Entities;

namespace PakMart.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<PictureBinary> PictureBinary { get; set; }
        public DbSet<ProductCategoryMapping> Product_Category_Mapping { get; set; }
        public DbSet<ProductManufacturerMapping> Product_Manufacturer_Mapping { get; set; }
        public DbSet<ProductPictureMapping> Product_Picture_Mapping { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Buyer", NormalizedName = "BUYER" },
                new IdentityRole { Id = "3", Name = "Seller", NormalizedName = "SELLER" }
            );
        }
    }
}
