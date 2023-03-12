using System.Reflection;
using Crud.Application.Orders.OrderItems;
using Crud.Application.Orders.OrderItems.Interfaces;
using Crud.Application.Orders.Orders;
using Crud.Application.Orders.Orders.Interfaces;
using Crud.Application.Providers;
using Crud.Application.Providers.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services.AddAutoMapper(Assembly.GetExecutingAssembly())
            .AddScoped<IOrderAppService, OrderAppService>()
            .AddScoped<IProviderAppService, ProviderAppService>()
            .AddScoped<IOrderItemAppService, OrderItemAppService>();
    }
}