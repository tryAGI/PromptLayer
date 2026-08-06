#nullable enable

namespace PromptLayer
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Add Trace to Draft Dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AddTraceToDatasetResponse> AddTraceToDatasetVersionAsync(

            global::PromptLayer.AddTraceToDatasetRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Trace to Draft Dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.AddTraceToDatasetResponse>> AddTraceToDatasetVersionAsResponseAsync(

            global::PromptLayer.AddTraceToDatasetRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Trace to Draft Dataset
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group to add the trace row to.
        /// </param>
        /// <param name="traceId">
        /// ID of the trace to add as a dataset row.
        /// </param>
        /// <param name="spanId">
        /// Optional span ID. When provided, the row is built from this span and its direct children become the dataset columns. When omitted, the full trace is added as the row.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AddTraceToDatasetResponse> AddTraceToDatasetVersionAsync(
            int datasetGroupId,
            string traceId,
            string? spanId = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}