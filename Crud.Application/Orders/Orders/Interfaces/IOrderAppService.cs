using Crud.Application.Providers.Dtos;

namespace Crud.Application.Orders.Orders.Interfaces;

public interface IOrderAppService
{
    Task<List<ProviderForViewOutputDto>> GetAllProvidersAsync();
}