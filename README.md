# dotnet-httpclient

This is my version of an http client for .NET. There are many like it but this one is mine. It uses [RestSharp](https://restsharp.dev/).

It has been heavily influenced from the [K8s client](https://github.com/kubernetes-client/csharp) as well as the netcore template in [openapi-generator](https://github.com/OpenAPITools/openapi-generator/tree/master/modules/openapi-generator/src/main/resources/csharp-netcore). 

You are free to use it anywhere you like.

## Get started

```c#
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
```
