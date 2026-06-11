#nullable enable

namespace PromptLayer
{
    public partial interface ITrackingClient
    {
        /// <summary>
        /// Request Analytics Custom Analytics
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.RequestAnalyticsCustomAnalyticsResponse> GetRequestAnalyticsCustomAnalyticsAsync(

            global::PromptLayer.RequestAnalyticsCustomAnalyticsQuery request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Analytics Custom Analytics
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.RequestAnalyticsCustomAnalyticsResponse>> GetRequestAnalyticsCustomAnalyticsAsResponseAsync(

            global::PromptLayer.RequestAnalyticsCustomAnalyticsQuery request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Analytics Custom Analytics
        /// </summary>
        /// <param name="filterGroup">
        /// Nested filter group with AND/OR logic.
        /// </param>
        /// <param name="q">
        /// Free-text search query.
        /// </param>
        /// <param name="sortBy">
        /// Accepted for compatibility; does not affect aggregated output.
        /// </param>
        /// <param name="sortOrder"></param>
        /// <param name="customCharts">
        /// One or more chart definitions to compute. Chart ids must be unique.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.RequestAnalyticsCustomAnalyticsResponse> GetRequestAnalyticsCustomAnalyticsAsync(
            global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSpec> customCharts,
            global::PromptLayer.StructuredFilterGroup? filterGroup = default,
            string? q = default,
            global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy? sortBy = default,
            global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder? sortOrder = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}