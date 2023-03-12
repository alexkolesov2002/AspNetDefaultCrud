using AutoMapper;
using Crud.Application.Mapper;
using Crud.Application.Orders.Orders.Interfaces;
using Crud.Application.Providers.Dtos;
using Crud.Core.Orders;
using Crud.Core.Providers;
using Crud.EntityFramework.Repository;

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

    public Task<List<ProviderForViewOutputDto>> GetAllProvidersAsync()
    {
        throw new NotImplementedException();
    }
}