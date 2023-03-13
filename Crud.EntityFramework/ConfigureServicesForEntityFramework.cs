using Crud.Core;
using Crud.Core.Orders;
using Crud.Core.Providers;
using Crud.EntityFramework.Interfaces;
using Crud.EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Crud.EntityFramework;

public static class ConfigureServicesForEntityFramework
{
    public static IServiceCollection AddDataServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services.AddDbContext<CrudDbContext>(builder =>
                builder.UseLazyLoadingProxies()
                    .UseSqlServer(configuration.GetConnectionString("CrudDb")))
            .AddScoped<ICrudDbContext, CrudDbContext>()
        .AddScoped(typeof(IRepository<>), typeof(Repository<>));
       /* .AddScoped<IRepository<Order>, OrderRepository>()
        .AddScoped<IRepository<OrderItem>, OrderItemRepository>();*/
    }
}