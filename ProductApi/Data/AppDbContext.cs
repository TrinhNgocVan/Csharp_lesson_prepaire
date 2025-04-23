using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();

    public DbSet<Producer> Producers => Set<Producer>();

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Product>()
        .HasOne(p => p.Producer)
        .WithMany(pr => pr.Products)
        .HasForeignKey(p => p.ProducerId)
        // .OnDelete(DeleteBehavior.Cascade)
        ;
    }
}
