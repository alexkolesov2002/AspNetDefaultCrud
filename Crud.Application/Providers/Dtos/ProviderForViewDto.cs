using Crud.Application.Help;
using Crud.Application.Mapper;
using Crud.Core.Providers;

namespace Crud.Application.Providers.Dtos;

public class ProviderForViewDto : EntityDto<int>, IMapper<Provider>
{
    public string Name { get; set; }
}