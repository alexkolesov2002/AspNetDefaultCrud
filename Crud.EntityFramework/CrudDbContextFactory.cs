using Crud.Core.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Crud.EntityFramework;

public class CrudDbContextFactory : IDesignTimeDbContextFactory<CrudDbContext>
{
    public CrudDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CrudDbContext>();
        var configBuilder = new ConfigurationBuilder();
        var path = WebContentDirectoryFinder.CalculateContentRootFolder();

        configBuilder.SetBasePath(path);
        configBuilder.AddJsonFile("appsettings.json");
        var config = configBuilder.Build();


        var connectionString = config.GetConnectionString("CrudDb");
        optionsBuilder.UseSqlServer(connectionString,
            opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(1).TotalSeconds));
        return new CrudDbContext(optionsBuilder.Options);
    }
}