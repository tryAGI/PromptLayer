namespace PromptLayer.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PromptLayerClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PROMPTLAYER_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PROMPTLAYER_API_KEY environment variable is not found.");

        var client = new PromptLayerClient(apiKey);
        
        return client;
    }
}
