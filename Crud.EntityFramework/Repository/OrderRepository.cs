using Crud.Core.Orders;
using Crud.EntityFramework.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crud.EntityFramework.Repository;

/*public class OrderRepository : Repository<Order>
{
    private readonly ICrudDbContext _context;
    
    public OrderRepository(ICrudDbContext context) : base(context.Orders, context)
    {
        _context = context;
    }
}*/