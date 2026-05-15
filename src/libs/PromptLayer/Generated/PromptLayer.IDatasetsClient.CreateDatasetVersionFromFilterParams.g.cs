#nullable enable

namespace PromptLayer
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset Version from Filter Params
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(

            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Version from Filter Params
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse>> CreateDatasetVersionFromFilterParamsAsResponseAsync(

            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Version from Filter Params
        /// </summary>
        /// <param name="datasetGroupId">
        /// Dataset group that will receive the generated dataset version.
        /// </param>
        /// <param name="requestLogIds">
        /// Explicit request log IDs to snapshot. When provided, this mode takes precedence over filter_group.
        /// </param>
        /// <param name="filterGroup">
        /// Structured request-log filters used to populate the dataset asynchronously.
        /// </param>
        /// <param name="q">
        /// Free-text request-log search query applied with filter_group.
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder"></param>
        /// <param name="variablesToParse">
        /// Request fields or variables to parse into dataset columns.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(
            int datasetGroupId,
            global::System.Collections.Generic.IList<int>? requestLogIds = default,
            global::PromptLayer.StructuredFilterGroup? filterGroup = default,
            string? q = default,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy? sortBy = default,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? sortOrder = default,
            global::System.Collections.Generic.IList<string>? variablesToParse = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}