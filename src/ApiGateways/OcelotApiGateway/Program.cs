using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", true, true);

builder.Services.AddOcelot()
          .AddCacheManager(settings => settings.WithDictionaryHandle());

builder.Services.AddHealthChecks();

var app = builder.Build();
await Configure();

app.Run();



async Task Configure()
{
    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseRouting();

    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapGet("/", () => "Hello World!");

        endpoints.MapHealthChecks("/hc", new HealthCheckOptions()
        {
            Predicate = _ => true,
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });
    });


    await app.UseOcelot();
}