#nullable enable

namespace PromptLayer
{
    public partial interface ITrackingClient
    {
        /// <summary>
        /// Request Analytics
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.RequestAnalyticsResponse> GetRequestAnalyticsAsync(

            global::PromptLayer.RequestLogQuery request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Analytics
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.RequestAnalyticsResponse>> GetRequestAnalyticsAsResponseAsync(

            global::PromptLayer.RequestLogQuery request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Analytics
        /// </summary>
        /// <param name="filterGroup">
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </param>
        /// <param name="q">
        /// Free-text search query. Searches across the prompt input and LLM output text using fuzzy prefix matching.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort results by. Does not affect aggregated output for `/requests/analytics`.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Must be provided together with sort_by.
        /// </param>
        /// <param name="metadataCostBreakdownKey">
        /// When provided, the analytics response includes a `metadataValueBreakdown` array with cost and request counts for each value of this metadata key. Omit or pass null to get an aggregate breakdown across the top metadata keys.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.RequestAnalyticsResponse> GetRequestAnalyticsAsync(
            global::PromptLayer.StructuredFilterGroup? filterGroup = default,
            string? q = default,
            global::PromptLayer.RequestLogQuerySortBy? sortBy = default,
            global::PromptLayer.RequestLogQuerySortOrder? sortOrder = default,
            string? metadataCostBreakdownKey = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}