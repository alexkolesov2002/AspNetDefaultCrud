using AutoMapper;
using Crud.Application.Providers.Dtos;
using Crud.Application.Providers.Interfaces;
using Crud.Core.Providers;
using Crud.EntityFramework.Repository;

namespace Crud.Application.Providers;

public class ProviderAppService : IProviderAppService
{
    private readonly IRepository<Provider> _providerRepository;
    private readonly IMapper _mapper;

    public ProviderAppService(IRepository<Provider> providerRepository, IMapper mapper)
    {
        _providerRepository = providerRepository;
        _mapper = mapper;
    }

    public async Task<List<ProviderForViewDto>> GetAllProvidersAsync()
    {
        return _mapper.Map<List<ProviderForViewDto>>(
            await _providerRepository.GetAsync());
    }
}