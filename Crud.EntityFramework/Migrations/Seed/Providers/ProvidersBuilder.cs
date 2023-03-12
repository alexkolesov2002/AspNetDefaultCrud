using Crud.Core.Providers;
using Crud.Core.Providers.StaticConst;

namespace Crud.EntityFramework.Migrations.Seed.Providers;

public class ProvidersBuilder : BuilderBase
{
    public ProvidersBuilder(CrudDbContext context) : base(context)
    {
    }

    public override void Create()
    {
        CreateProviders();
    }

    private void CreateProviders()
    {
        var ironProvider = _context.Providers.FirstOrDefault(e => e.Name.Equals(ProviderStaticConst.Iron));
        if (ironProvider is null)
        {
            _context.Providers.Add(new Provider
            {
                Name = ProviderStaticConst.Iron
            });
            _context.SaveChanges();
        }

        var sandProvider = _context.Providers.FirstOrDefault(e => e.Name.Equals(ProviderStaticConst.Sand));
        if (sandProvider is null)
        {
            _context.Providers.Add(new Provider
            {
                Name = ProviderStaticConst.Sand
            });
            _context.SaveChanges();
        }

        var cardboardProvider = _context.Providers.FirstOrDefault(e => e.Name.Equals(ProviderStaticConst.Cardboard));
        if (cardboardProvider is null)
        {
            _context.Providers.Add(new Provider
            {
                Name = ProviderStaticConst.Cardboard
            });
            _context.SaveChanges();
        }
    }
}