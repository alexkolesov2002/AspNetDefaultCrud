using Crud.Application.Providers.Dtos;

namespace Crud.Application.Providers.Interfaces;

public interface IProviderAppService
{
    Task<List<ProviderForViewDto>> GetAllProvidersAsync();
}