namespace AStar.Dev.Api.Usage.Sdk;

/// <summary>
///     Represents the configuration settings for API usage, including connection and authentication details.
/// </summary>
public sealed class ApiUsageConfiguration
{
    /// <summary>
    ///     Specifies the name of the configuration section used to load settings for the <see cref="ApiUsageConfiguration" /> class.
    ///     This property provides a consistent identifier for the configuration section within
    ///     application configuration files, such as appsettings.json.
    /// </summary>
    public static string ConfigurationSectionName => "ApiUsageConfiguration";

    /// <summary>
    ///     Specifies the host name used for connecting to the API in the <see cref="ApiUsageConfiguration" /> class.
    ///     This property represents the endpoint or server address where the API service is hosted.
    /// </summary>
    public required string HostName { get; init; }

    /// <summary>
    ///     Represents the username required for authentication within the <see cref="ApiUsageConfiguration" /> class.
    ///     This property is essential for establishing a connection to the API or associated services.
    /// </summary>
    public required string UserName { get; init; }

    /// <summary>
    ///     Represents the password used for authenticating with the API. This property must be provided
    ///     as part of the configuration settings to ensure secure access to the API.
    /// </summary>
    public required string Password { get; init; }

    /// <summary>
    ///     Defines the name of the queue used for messaging or task distribution in the API usage configuration.
    ///     This property is required to identify the specific queue for sending and receiving messages
    ///     within the system's messaging infrastructure.
    /// </summary>
    public required string QueueName { get; init; }
}