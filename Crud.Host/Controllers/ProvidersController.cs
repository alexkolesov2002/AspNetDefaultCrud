using Crud.Application.Providers.Dtos;
using Crud.Application.Providers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Host.Controllers;

[Route("/api/services/app/[controller]/[action]")]
public class ProvidersController : ControllerBase
{
    private readonly IProviderAppService _providerAppService;

    public ProvidersController(IProviderAppService providerAppService)
    {
        _providerAppService = providerAppService;
    }

    [HttpGet]
    public async Task<List<ProviderForViewDto>> GetAllProvidersAsync()
    {
        return await _providerAppService.GetAllProvidersAsync();
    }
}