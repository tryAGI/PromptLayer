#nullable enable

namespace PromptLayer
{
    public partial interface ITrackingClient
    {
        /// <summary>
        /// Trace Analytics Custom Queries
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.RequestAnalyticsCustomAnalyticsResponse> GetTraceAnalyticsCustomAnalyticsAsync(

            global::PromptLayer.TraceAnalyticsCustomAnalyticsQuery request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trace Analytics Custom Queries
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.RequestAnalyticsCustomAnalyticsResponse>> GetTraceAnalyticsCustomAnalyticsAsResponseAsync(

            global::PromptLayer.TraceAnalyticsCustomAnalyticsQuery request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trace Analytics Custom Queries
        /// </summary>
        /// <param name="filterGroup">
        /// Nested filter tree. AND/OR are cross-span; SPAN_AND/SPAN_OR require one and the same span to satisfy every/any branch (span-level fields only).
        /// </param>
        /// <param name="customCharts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.RequestAnalyticsCustomAnalyticsResponse> GetTraceAnalyticsCustomAnalyticsAsync(
            global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpec> customCharts,
            global::PromptLayer.TraceStructuredFilterGroup? filterGroup = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}