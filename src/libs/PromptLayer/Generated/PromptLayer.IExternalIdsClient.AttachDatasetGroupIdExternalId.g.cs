#nullable enable

namespace PromptLayer
{
    public partial interface IExternalIdsClient
    {
        /// <summary>
        /// Attach Dataset Group External ID
        /// </summary>
        /// <param name="datasetGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ExternalIdAttachResponse> AttachDatasetGroupIdExternalIdAsync(
            int datasetGroupId,

            global::PromptLayer.AttachExternalIdRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Dataset Group External ID
        /// </summary>
        /// <param name="datasetGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ExternalIdAttachResponse>> AttachDatasetGroupIdExternalIdAsResponseAsync(
            int datasetGroupId,

            global::PromptLayer.AttachExternalIdRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Dataset Group External ID
        /// </summary>
        /// <param name="datasetGroupId"></param>
        /// <param name="source">
        /// The external system or namespace that owns the ID.
        /// </param>
        /// <param name="externalId">
        /// The identifier for this entity in the external system.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ExternalIdAttachResponse> AttachDatasetGroupIdExternalIdAsync(
            int datasetGroupId,
            string source,
            string externalId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}