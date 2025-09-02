using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Api.Usage.Sdk.Tests.Unit;

[TestSubject(typeof(ApiUsageConfiguration))]
public class ApiUsageConfigurationShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new ApiUsageConfiguration { HostName = "Mock host name", Password = null!, QueueName = "Mock Queue name", UserName = "Mock User name" }
           .ToJson()
           .ShouldMatchApproved();
}