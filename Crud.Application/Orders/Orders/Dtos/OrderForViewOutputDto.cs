using Crud.Application.Help;
using Crud.Application.Mapper;
using Crud.Application.Orders.OrderItems;
using Crud.Application.Orders.OrderItems.Dtos;
using Crud.Application.Providers.Dtos;
using Crud.Core.Orders;

namespace Crud.Application.Orders.Orders.Dtos;

public class OrderForViewOutputDto : EntityDto<int>, IMapper<OrderItem>
{
    public  string Number  { get; set; }

    public  DateTime Date  { get; set; }
    
    public  ProviderForViewOutputDto ProviderForView { get; set; }
    
    public virtual List<OrderItemForViewOutputDto> OrderItems { get; set; }
}