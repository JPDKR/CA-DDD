using System.Reflection;
using BuberDinner.Api.Common.Mapping;
using Mapster;
using MapsterMapper;

namespace BuberDinner.Api.Common.Filters;

public static class DependencyInjection
{
    public static IServiceCollection AddMappings(this IServiceCollection services)
    {
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();
        //services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());

        return services;
    }
}