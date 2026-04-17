#nullable enable

namespace PromptLayer
{
    public partial interface ISkillCollectionsClient
    {
        /// <summary>
        /// Update Skill Collection
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateSkillCollectionResponse> UpdateSkillCollectionPublicAsync(
            string identifier,

            global::PromptLayer.UpdateSkillCollectionRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Skill Collection
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateSkillCollectionResponse> UpdateSkillCollectionPublicAsync(
            string identifier,
            string? name = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}