#nullable enable

namespace PromptLayer
{
    public partial interface IExternalIdsClient
    {
        /// <summary>
        /// Attach Prompt Template External ID
        /// </summary>
        /// <param name="promptTemplateId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ExternalIdAttachResponse> AttachPromptTemplateIdExternalIdAsync(
            int promptTemplateId,

            global::PromptLayer.AttachExternalIdRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Prompt Template External ID
        /// </summary>
        /// <param name="promptTemplateId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ExternalIdAttachResponse>> AttachPromptTemplateIdExternalIdAsResponseAsync(
            int promptTemplateId,

            global::PromptLayer.AttachExternalIdRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Prompt Template External ID
        /// </summary>
        /// <param name="promptTemplateId"></param>
        /// <param name="source">
        /// The external system or namespace that owns the ID.
        /// </param>
        /// <param name="externalId">
        /// The identifier for this entity in the external system.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ExternalIdAttachResponse> AttachPromptTemplateIdExternalIdAsync(
            int promptTemplateId,
            string source,
            string externalId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}