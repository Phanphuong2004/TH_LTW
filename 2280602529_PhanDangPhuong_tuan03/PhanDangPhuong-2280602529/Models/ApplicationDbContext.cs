
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhanDangPhuong_2280602529.Models;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed dữ liệu mẫu cho Category
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Điện tử" },
            new Category { Id = 2, Name = "Gia dụng" },
            new Category { Id = 3, Name = "Thời trang" }
        );
    }
}