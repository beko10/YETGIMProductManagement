using Microsoft.EntityFrameworkCore;
using ProductManagement.EntityLayer.Concrete;

namespace ProductManagement.DataAccessLayer.Context;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-JH4RF0R;Database=ProductManagementDb;Trusted_Connection=True;Encrypt=False;");
    }
}
