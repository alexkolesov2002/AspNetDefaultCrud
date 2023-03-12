using Crud.Core;
using Crud.Core.Orders;
using Crud.Core.Providers;
using Microsoft.EntityFrameworkCore;

namespace Crud.EntityFramework.Interfaces;

public interface ICrudDbContext
{
    DbSet<Order> Orders { get; set; }

    DbSet<OrderItem> OrderItems { get; set; }

    DbSet<Provider> Providers { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new());
    
}