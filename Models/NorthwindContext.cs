using Microsoft.EntityFrameworkCore;
using NorthwindApp.Models;

public class NorthwindContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
