namespace PromptLayer;

public sealed partial class TrackingClient
{
    /// <summary>
    /// Searches tracked LLM request logs with the pre-regeneration convenience parameters.
    /// </summary>
    /// <param name="q">Free-text search query.</param>
    /// <param name="page">Page number for pagination.</param>
    /// <param name="perPage">Number of results per page.</param>
    /// <param name="includePromptName">Whether to include the prompt template name in each result item.</param>
    /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>The paginated request-log search response.</returns>
    public Task<SearchRequestLogsResponse> SearchRequestLogsAsync(
        string? q = default,
        int? page = default,
        int? perPage = default,
        bool? includePromptName = default,
        AutoSDKRequestOptions? requestOptions = default,
        CancellationToken cancellationToken = default)
    {
        var request = new RequestLogQuery
        {
            Q = q,
        };

        if (page is not null)
        {
            request.AdditionalProperties["page"] = page.Value;
        }

        if (perPage is not null)
        {
            request.AdditionalProperties["per_page"] = perPage.Value;
        }

        if (includePromptName is not null)
        {
            request.AdditionalProperties["include_prompt_name"] = includePromptName.Value;
        }

        return SearchRequestLogsAsync(
            request: request,
            requestOptions: requestOptions,
            cancellationToken: cancellationToken);
    }
}
