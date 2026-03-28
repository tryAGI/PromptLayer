/* order: 30, title: Workflows, slug: workflows */

namespace PromptLayer.IntegrationTests;

public partial class Tests
{
    //// PromptLayer workflows let you chain together prompt templates,
    //// LLM calls, and custom logic into reusable pipelines.

    [TestMethod]
    public async Task Example_ListWorkflows()
    {
        using var client = GetAuthenticatedClient();

        //// List available workflows with pagination.
        //// Each workflow includes its name, latest version number,
        //// and any release labels (e.g., "prod", "staging").
        var response = await client.Workflow.ListWorkflowsAsync(
            page: 1,
            perPage: 10);

        response.Should().NotBeNull();
        response.Items.Should().NotBeNull();
        response.Page.Should().Be(1);
        response.Pages.Should().BeGreaterThanOrEqualTo(0);

        Console.WriteLine($"Total workflows: {response.Total}, Page: {response.Page}/{response.Pages}");

        foreach (var workflow in response.Items)
        {
            var labels = workflow.ReleaseLabels.Count > 0
                ? string.Join(", ", workflow.ReleaseLabels)
                : "none";
            Console.WriteLine($"  - {workflow.Name} (id: {workflow.Id}, version: {workflow.LatestVersionNumber}, labels: {labels})");
        }
    }
}
