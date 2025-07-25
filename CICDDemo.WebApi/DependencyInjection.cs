using CICDDemo.WebApi.Configurations;

namespace CICDDemo.WebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddCustomConfiguration(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<ConnectionStrings>(configuration.GetSection("ConnectionStrings"));
        services.Configure<ApiSettings>(configuration.GetSection("ApiSettings"));

        return services;
    }
}