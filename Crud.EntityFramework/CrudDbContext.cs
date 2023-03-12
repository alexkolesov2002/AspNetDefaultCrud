using Crud.Core;
using Crud.Core.Orders;
using Crud.Core.Providers;
using Crud.EntityFramework.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crud.EntityFramework;

public class CrudDbContext : DbContext, ICrudDbContext
{
    public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options)
    {
    }
    
    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderItem> OrderItems { get; set; }

    public DbSet<Provider> Providers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderItem>()
            .Property(dec => dec.Quantity)
            .HasPrecision(18, 3);
        
        modelBuilder
            .Entity<Order>()
            .HasAlternateKey(u => new { u.Number, u.ProviderId });
        
        base.OnModelCreating(modelBuilder);
    }
}