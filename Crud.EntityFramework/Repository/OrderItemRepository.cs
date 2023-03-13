using Crud.Core;
using Crud.Core.Orders;
using Crud.Core.Providers;
using Crud.EntityFramework.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crud.EntityFramework.Repository;

/*public class OrderItemRepository : Repository<OrderItem>
{
    private readonly ICrudDbContext _context;


    public OrderItemRepository(ICrudDbContext context) : base(context.OrderItems, context)
    {
        _context = context;
    }
}*/