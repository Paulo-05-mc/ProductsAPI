using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;
namespace ProductsAPI.Data;

public class AppDDbContext(DbContextOptions<AppDDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}