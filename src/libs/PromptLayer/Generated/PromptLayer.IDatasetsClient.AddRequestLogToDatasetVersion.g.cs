#nullable enable

namespace PromptLayer
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Add Request Log to Draft Dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DraftDatasetVersionResponse> AddRequestLogToDatasetVersionAsync(

            global::PromptLayer.AddRequestLogToDatasetRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Request Log to Draft Dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.DraftDatasetVersionResponse>> AddRequestLogToDatasetVersionAsResponseAsync(

            global::PromptLayer.AddRequestLogToDatasetRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Request Log to Draft Dataset
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group containing the draft.
        /// </param>
        /// <param name="requestLogId">
        /// ID of the request log to add as a dataset row.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DraftDatasetVersionResponse> AddRequestLogToDatasetVersionAsync(
            int datasetGroupId,
            int requestLogId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}