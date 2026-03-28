/* order: 20, title: Request Tracking, slug: request-tracking */

namespace PromptLayer.IntegrationTests;

public partial class Tests
{
    //// PromptLayer automatically tracks all LLM requests routed through it,
    //// allowing you to search and analyze your usage history.

    [TestMethod]
    public async Task Example_SearchRequestLogs()
    {
        using var client = GetAuthenticatedClient();

        //// Search tracked LLM request logs with pagination.
        //// You can optionally provide a free-text query (`q`) to search
        //// across prompt inputs and LLM outputs using fuzzy prefix matching.
        var response = await client.Tracking.SearchRequestLogsAsync(
            page: 1,
            perPage: 5);

        response.Should().NotBeNull();
        response.Success.Should().BeTrue();
        response.Page.Should().Be(1);
        response.Total.Should().NotBeNull();

        Console.WriteLine($"Total tracked requests: {response.Total}, Page: {response.Page}/{response.Pages}");
    }

    [TestMethod]
    public async Task Example_SearchRequestLogsWithQuery()
    {
        using var client = GetAuthenticatedClient();

        //// Search request logs with a text query to filter results.
        //// The query searches across prompt input and LLM output text.
        var response = await client.Tracking.SearchRequestLogsAsync(
            q: "hello",
            page: 1,
            perPage: 5,
            includePromptName: true);

        response.Should().NotBeNull();
        response.Success.Should().BeTrue();
        response.Total.Should().NotBeNull();

        Console.WriteLine($"Matching requests for 'hello': {response.Total}");
    }
}
