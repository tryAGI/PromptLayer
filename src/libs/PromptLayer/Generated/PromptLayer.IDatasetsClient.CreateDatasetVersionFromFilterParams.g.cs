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
        /// ID of the dataset group where the new version will be created.
        /// </param>
        /// <param name="requestLogIds">
        /// Explicit list of request_log ids to include. Capped at 50,000. All ids must belong to the same workspace as the dataset group; cross-workspace ids return 400. Datasets created in this mode are static snapshots — `filter_params` is left null and the dataset cannot be refreshed via run-report.
        /// </param>
        /// <param name="filterGroup">
        /// Structured filter group, identical in shape to the one accepted by `POST /api/public/v2/requests/search`. The full payload is persisted to the dataset so it can be replayed on refresh.
        /// </param>
        /// <param name="q">
        /// Free-text search query applied alongside `filter_group`. Mirrors `q` from the unified request-log search.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort the structured query by. Same allowed values as `POST /api/public/v2/requests/search` (e.g. `request_start_time`, `input_tokens`, `output_tokens`, `cost`, `latency_ms`, `status`).
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to `desc` when `sort_by` is provided.
        /// </param>
        /// <param name="variablesToParse">
        /// List of input variables to extract as columns in the resulting dataset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(
            int datasetGroupId,
            global::System.Collections.Generic.IList<int>? requestLogIds = default,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestFilterGroup? filterGroup = default,
            string? q = default,
            string? sortBy = default,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? sortOrder = default,
            global::System.Collections.Generic.IList<string>? variablesToParse = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}