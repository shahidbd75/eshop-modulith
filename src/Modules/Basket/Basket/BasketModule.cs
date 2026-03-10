using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket;

public static class BasketModule
{
    public static IServiceCollection AddBusketModule(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
        // Register services related to the Catelog module here
    }

    public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app) { return app; }
}
