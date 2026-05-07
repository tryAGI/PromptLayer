#nullable enable

namespace PromptLayer
{
    public partial interface IExternalIdsClient
    {
        /// <summary>
        /// Delete Skill Collection External ID
        /// </summary>
        /// <param name="skillCollectionId"></param>
        /// <param name="source"></param>
        /// <param name="externalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ExternalIdDeleteResponse> DeleteSkillCollectionIdExternalIdAsync(
            string skillCollectionId,
            string source,
            string externalId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Skill Collection External ID
        /// </summary>
        /// <param name="skillCollectionId"></param>
        /// <param name="source"></param>
        /// <param name="externalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ExternalIdDeleteResponse>> DeleteSkillCollectionIdExternalIdAsResponseAsync(
            string skillCollectionId,
            string source,
            string externalId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}