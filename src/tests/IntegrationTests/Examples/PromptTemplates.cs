/* order: 10, title: Prompt Templates, slug: prompt-templates */

namespace PromptLayer.IntegrationTests;

public partial class Tests
{
    //// PromptLayer provides a centralized registry of prompt templates
    //// that you can version, label, and manage through the API.

    [TestMethod]
    public async Task Example_ListPromptTemplates()
    {
        using var client = GetAuthenticatedClient();

        //// List available prompt templates with pagination.
        //// The response includes template metadata such as name, version,
        //// and commit message.
        var response = await client.PromptTemplates.GetAllPromptTemplatesGetAsync(
            page: 1,
            perPage: 10);

        response.Should().NotBeNull();
        response.Items.Should().NotBeNull();
        response.Page.Should().Be(1);
        response.Total.Should().BeGreaterThanOrEqualTo(0);

        Console.WriteLine($"Total templates: {response.Total}, Page: {response.Page}/{response.Pages}");

        foreach (var template in response.Items)
        {
            Console.WriteLine($"  - {template.PromptName} (id: {template.Id}, version: {template.Version})");
        }
    }

    [TestMethod]
    public async Task Example_GetPromptTemplateRaw()
    {
        using var client = GetAuthenticatedClient();

        //// First, list templates to find one we can retrieve.
        var listResponse = await client.PromptTemplates.GetAllPromptTemplatesGetAsync(
            page: 1,
            perPage: 1);

        listResponse.Items.Should().NotBeNull();

        if (listResponse.Items.Count == 0)
        {
            Assert.Inconclusive("No prompt templates available to retrieve.");
            return;
        }

        var templateName = listResponse.Items[0].PromptName;

        //// Retrieve the raw prompt template data by name.
        //// This returns the full template content without applying input variables,
        //// which is useful for inspection, caching, or syncing.
        var response = await client.PromptTemplates.GetPromptTemplateRawAsync(
            identifier: templateName);

        response.Should().NotBeNull();
        response.PromptName.Should().Be(templateName);
        response.Id.Should().BeGreaterThan(0);

        Console.WriteLine($"Template: {response.PromptName} (version: {response.Version})");
    }
}
