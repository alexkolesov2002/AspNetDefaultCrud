using Crud.Core.Providers;
using Crud.EntityFramework.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Crud.EntityFramework.Repository;

public class ProviderRepository : Repository<Provider>
{
    private readonly ICrudDbContext _context;
    
    public ProviderRepository(ICrudDbContext context) : base(context.Providers, context)
    {
        _context = context;
    }
}