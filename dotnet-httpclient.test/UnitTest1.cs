using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DotnetHttpClient;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace dotnet_httpclient.test
{
  public class UnitTest1
  {
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
      _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Test1()
    {
      var cts = new CancellationTokenSource();

      // Set the API base path
      var apiUri = new Uri("https://api.github.com");

      // Create how the http client will be configured
      var clientConfig = new Configuration(apiUri);

      // Create the http client
      var client = new ApiClient(clientConfig);

      // Configure the request
      var requestOptions = new RequestOptions() { HeaderParameters = new Dictionary<string, string>(){ {"user-agent",@"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/93.0.4577.63 Safari/537.36"} } };

      // Send the request as GET and parse response as Json
      var githubResponse = await client.GetAsync<GitHubResponse>("", requestOptions, cts.Token);

      // Validate response
      githubResponse.Should().NotBeNull();
      githubResponse.CurrentUserUrl.Should().Be("https://api.github.com/user");

      _testOutputHelper.WriteLine(githubResponse.ToString());
    }
  }
}
