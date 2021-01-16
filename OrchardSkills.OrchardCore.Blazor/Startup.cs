using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace OrchardSkills.OrchardCore.Blazor
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddServerSideBlazor();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                name: "Blazor",
                areaName: "OrchardSkills.OrchardCore.Blazor",
                pattern: "Blazor",
                defaults: new { controller = "Blazor", action = "Index" }
            );
        }
    }
}
