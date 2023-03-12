namespace Crud.Host;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(builder => { builder.UseStartup<Startup>(); });
    }
}