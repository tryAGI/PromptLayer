#nullable enable

namespace PromptLayer
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Save Draft Dataset Version
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.SaveDraftDatasetVersionResponse> SaveDraftDatasetVersionAsync(

            global::PromptLayer.SaveDraftDatasetVersionRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save Draft Dataset Version
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group containing the draft to save
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.SaveDraftDatasetVersionResponse> SaveDraftDatasetVersionAsync(
            int datasetGroupId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}