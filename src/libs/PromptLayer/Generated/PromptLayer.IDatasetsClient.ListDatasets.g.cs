#nullable enable

namespace PromptLayer
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Datasets
        /// </summary>
        /// <param name="datasetGroupId"></param>
        /// <param name="promptId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="reportId"></param>
        /// <param name="name"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="createdByEmail"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="updatedBefore"></param>
        /// <param name="externalSource"></param>
        /// <param name="externalId"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListDatasetsResponse> ListDatasetsAsync(
            int? datasetGroupId = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            int? workspaceId = default,
            int? reportId = default,
            string? name = default,
            global::PromptLayer.ListDatasetsStatus? status = default,
            int? page = default,
            int? perPage = default,
            string? createdByEmail = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            string? externalSource = default,
            string? externalId = default,
            global::PromptLayer.ListDatasetsSortBy? sortBy = default,
            global::PromptLayer.ListDatasetsSortOrder? sortOrder = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Datasets
        /// </summary>
        /// <param name="datasetGroupId"></param>
        /// <param name="promptId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="reportId"></param>
        /// <param name="name"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="createdByEmail"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="updatedBefore"></param>
        /// <param name="externalSource"></param>
        /// <param name="externalId"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListDatasetsResponse>> ListDatasetsAsResponseAsync(
            int? datasetGroupId = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            int? workspaceId = default,
            int? reportId = default,
            string? name = default,
            global::PromptLayer.ListDatasetsStatus? status = default,
            int? page = default,
            int? perPage = default,
            string? createdByEmail = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? updatedAfter = default,
            global::System.DateTime? updatedBefore = default,
            string? externalSource = default,
            string? externalId = default,
            global::PromptLayer.ListDatasetsSortBy? sortBy = default,
            global::PromptLayer.ListDatasetsSortOrder? sortOrder = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}