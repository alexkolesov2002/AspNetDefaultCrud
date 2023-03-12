using System.Transactions;
using Crud.EntityFramework.Migrations.Seed.Providers;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.EntityFramework.Migrations.Seed
{
    public static class SeedHelper
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            SeedHostDb(serviceScope.ServiceProvider.GetService<CrudDbContext>()!);
        }

        private static void SeedHostDb(CrudDbContext context)
        {
            new ProvidersBuilder(context).Create();
        }

       
    }
}
