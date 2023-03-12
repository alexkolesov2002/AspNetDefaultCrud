using Crud.Application.Help.Pagination.Dtos;
using Crud.Application.Orders.Orders.Dtos;
using Crud.Application.Orders.Orders.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Host.Controllers;

[Route("/api/services/app/[controller]/[action]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderAppService _orderAppService;

    public OrdersController(IOrderAppService orderAppService)
    {
        _orderAppService = orderAppService;
    }

    [HttpGet]
    public async Task<PagedResultDto<OrderForViewOutputDto>> GetAllOrders(GetAllOrdersInput input)
    {
        return await _orderAppService.GetAllOrders(input);
    }
}