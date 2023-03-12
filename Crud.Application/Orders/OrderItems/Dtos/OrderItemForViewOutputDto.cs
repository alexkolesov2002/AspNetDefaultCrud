using Crud.Application.Help;
using Crud.Application.Mapper;
using Crud.Core.Orders;

namespace Crud.Application.Orders.OrderItems.Dtos;

public class OrderItemForViewOutputDto : EntityDto<int>, IMapper<OrderItem>
{
    public int OrderId { get; set; }

    public string Name { get; set; }

    public decimal Quantity { get; set; }

    public string Unit { get; set; }
}