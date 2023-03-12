using Crud.Application.Help.Pagination.Dtos;
using Crud.Application.Orders.Orders.Dtos;
using Crud.Application.Providers.Dtos;

namespace Crud.Application.Orders.Orders.Interfaces;

public interface IOrderAppService
{
    Task<PagedResultDto<OrderForViewOutputDto>> GetAllOrders(GetAllOrdersInput input);
}