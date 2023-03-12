using AutoMapper;
using Crud.Application.Help.Pagination.Dtos;
using Crud.Application.Mapper;
using Crud.Application.Orders.Orders.Dtos;
using Crud.Application.Orders.Orders.Interfaces;
using Crud.Application.Providers.Dtos;
using Crud.Core.Orders;
using Crud.Core.Providers;
using Crud.EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;

namespace Crud.Application.Orders.Orders;

public class OrderAppService : IOrderAppService
{
    private readonly IRepository<Order> _orderRepository;
    private readonly IMapper _mapper;

    public OrderAppService(IRepository<Provider> orderRepository, IMapper mapper, IRepository<Order> orderRepository1)
    {
        _mapper = mapper;
        _orderRepository = orderRepository1;
    }

    public async Task<PagedResultDto<OrderForViewOutputDto>> GetAllOrders(GetAllOrdersInput input)
    {
        var ordersQuery = (await _orderRepository.GetAsync());

        var totalCount = ordersQuery.Count();

        return new PagedResultDto<OrderForViewOutputDto>(
            totalCount,
            _mapper.Map<IReadOnlyList<OrderForViewOutputDto>>(await ordersQuery.ToListAsync())
        );
    }
}