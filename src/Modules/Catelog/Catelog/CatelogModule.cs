using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catelog;

public static class CatelogModule
{
    public static IServiceCollection AddCatelogModule(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
        // Register services related to the Catelog module here
    }

}
