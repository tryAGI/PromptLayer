using System.Text.Json;
using Microsoft.Extensions.AI;

namespace PromptLayer;

/// <summary>
/// Extensions for using PromptLayerClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class PromptLayerToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists prompt templates.
    /// Useful for agents that need to discover available prompt templates.
    /// </summary>
    /// <param name="client">The PromptLayer client.</param>
    /// <param name="perPage">Maximum number of templates to return per page (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListPromptsTool(
        this PromptLayerClient client,
        int perPage = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (int? page, string? name, CancellationToken cancellationToken) =>
            {
                var response = await client.PromptTemplates.GetAllPromptTemplatesGetAsync(
                    page: page ?? 1,
                    perPage: perPage,
                    name: name,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total = response.Total,
                    page = response.Page,
                    pages = response.Pages,
                    items = response.Items.Select(p => new
                    {
                        id = p.Id,
                        name = p.PromptName,
                        version = p.Version,
                        commitMessage = p.CommitMessage,
                    }),
                });
            },
            name: "ListPromptTemplates",
            description: "Lists available prompt templates in PromptLayer. Optionally filter by name. Returns template IDs, names, versions, and commit messages.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves a specific prompt template by identifier.
    /// Useful for agents that need to load a prompt template with its content.
    /// </summary>
    /// <param name="client">The PromptLayer client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetPromptTool(this PromptLayerClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string identifier, int? version, string? label, CancellationToken cancellationToken) =>
            {
                var response = await client.PromptTemplates.GetPromptTemplateRawAsync(
                    identifier: identifier,
                    version: version,
                    label: label,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = response.Id,
                    name = response.PromptName,
                    version = response.Version,
                    tags = response.Tags,
                    commitMessage = response.CommitMessage,
                    createdAt = response.CreatedAt,
                    promptTemplate = response.PromptTemplate,
                });
            },
            name: "GetPromptTemplate",
            description: "Retrieves a specific prompt template from PromptLayer by its name or ID. Optionally specify a version number or label. Returns the template content, metadata, and version info.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that searches tracked LLM request logs.
    /// Useful for agents that need to analyze or audit LLM usage.
    /// </summary>
    /// <param name="client">The PromptLayer client.</param>
    /// <param name="perPage">Maximum number of results to return per page (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSearchRequestsTool(
        this PromptLayerClient client,
        int perPage = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? query, int? page, CancellationToken cancellationToken) =>
            {
                var response = await client.Tracking.SearchRequestLogsAsync(
                    q: query,
                    page: page ?? 1,
                    perPage: perPage,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total = response.Total,
                    page = response.Page,
                    pages = response.Pages,
                    items = response.Items,
                });
            },
            name: "SearchRequestLogs",
            description: "Searches tracked LLM request logs in PromptLayer. Optionally filter by a text query. Returns paginated request log entries including inputs, outputs, and metadata.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists workflows.
    /// Useful for agents that need to discover available PromptLayer workflows.
    /// </summary>
    /// <param name="client">The PromptLayer client.</param>
    /// <param name="perPage">Maximum number of workflows to return per page (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListWorkflowsTool(
        this PromptLayerClient client,
        int perPage = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (int? page, CancellationToken cancellationToken) =>
            {
                var response = await client.Workflow.ListWorkflowsAsync(
                    page: page ?? 1,
                    perPage: perPage,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total = response.Total,
                    page = response.Page,
                    pages = response.Pages,
                    items = response.Items.Select(w => new
                    {
                        id = w.Id,
                        name = w.Name,
                        latestVersion = w.LatestVersionNumber,
                        releaseLabels = w.ReleaseLabels,
                    }),
                });
            },
            name: "ListWorkflows",
            description: "Lists available workflows in PromptLayer. Returns workflow IDs, names, latest version numbers, and release labels.");
    }
}
