using Crud.Application;
using Crud.EntityFramework;
using Crud.EntityFramework.Migrations.Seed;
using Crud.Host.Middlewares;
using Crud.Host.Models;
using Microsoft.OpenApi.Models;

namespace Crud.Host;

public class Startup
{
    private IConfiguration _configuration { get; set; }

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddMvc().AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.ContractResolver = new PatchRequestContractResolver();
        });
        services.AddApplicationServices();
        services.AddDataServices(_configuration);
        services.AddHostServices();
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
            {
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
                policy.AllowAnyOrigin();
            });
        });
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "Crud", Version = "v1" });
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "Online Shop v1"));
        }

        app.UseCors("AllowAll");
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseMiddleware<ExceptionHandlingMiddleware>();
        app.UseEndpoints(builder => { builder.MapControllers(); });
        app.SeedData();
        app.SeedData();
    }
}