#nullable enable

namespace PromptLayer
{
    public partial interface IExternalIdsClient
    {
        /// <summary>
        /// List Skill Collection External IDs
        /// </summary>
        /// <param name="skillCollectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ExternalIdsListResponse> ListSkillCollectionIdExternalIdsAsync(
            string skillCollectionId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Skill Collection External IDs
        /// </summary>
        /// <param name="skillCollectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ExternalIdsListResponse>> ListSkillCollectionIdExternalIdsAsResponseAsync(
            string skillCollectionId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}