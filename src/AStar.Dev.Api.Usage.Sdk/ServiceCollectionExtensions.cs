using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AStar.Dev.Api.Usage.Sdk;

/// <summary>
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configurationManager"></param>
    /// <param name="executingAssembly"></param>
    /// <returns></returns>

    // ReSharper disable once UnusedParameter.Global
#pragma warning disable IDE0060
    public static IServiceCollection AddUsageServices(this IServiceCollection services, ConfigurationManager configurationManager, Assembly executingAssembly)
#pragma warning restore IDE0060
    {
        // services.AddMediatR(cfg =>
        //           {
        //     cfg.RegisterServicesFromAssembly(executingAssembly)
        //        .AddOpenBehavior(typeof(UsageMetricHandler<,>));
        //           });

        _ = services.AddSingleton<Send>();

        _ = services
            .AddOptions<ApiUsageConfiguration>()
            .Bind(configurationManager.GetSection(ApiUsageConfiguration.ConfigurationSectionName));

        return services;
    }
}