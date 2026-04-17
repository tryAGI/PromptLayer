#nullable enable

namespace PromptLayer
{
    public partial interface ISkillCollectionsClient
    {
        /// <summary>
        /// Get Skill Collection
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="format"></param>
        /// <param name="label"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.GetSkillCollectionResponse> GetSkillCollectionPublicAsync(
            string identifier,
            global::PromptLayer.GetSkillCollectionPublicFormat? format = default,
            string? label = default,
            int? version = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}