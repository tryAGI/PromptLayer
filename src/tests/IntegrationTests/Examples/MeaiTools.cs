/* order: 40, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace PromptLayer.IntegrationTests;

public partial class Tests
{
    //// PromptLayer provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// prompt template management, request tracking, and workflow discovery.

    [TestMethod]
    public async Task Meai_AsListPromptsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists prompt templates:
        var tool = client.AsListPromptsTool(perPage: 5);

        tool.Name.Should().Be("ListPromptTemplates");
        tool.Description.Should().Contain("prompt");

        //// Invoke the tool without filters to get all templates:
        var result = await tool.InvokeAsync(
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListPromptTemplates result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsGetPromptTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that retrieves a specific prompt template by name or ID:
        var tool = client.AsGetPromptTool();

        tool.Name.Should().Be("GetPromptTemplate");
        tool.Description.Should().Contain("prompt");
    }

    [TestMethod]
    public async Task Meai_AsSearchRequestsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that searches tracked LLM request logs:
        var tool = client.AsSearchRequestsTool(perPage: 5);

        tool.Name.Should().Be("SearchRequestLogs");
        tool.Description.Should().Contain("request");

        //// Invoke the tool to search all request logs:
        var result = await tool.InvokeAsync(
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"SearchRequestLogs result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsListWorkflowsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists available workflows:
        var tool = client.AsListWorkflowsTool(perPage: 5);

        tool.Name.Should().Be("ListWorkflows");
        tool.Description.Should().Contain("workflow");

        //// Invoke the tool to list workflows:
        var result = await tool.InvokeAsync(
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListWorkflows result: {result}");
    }
}
