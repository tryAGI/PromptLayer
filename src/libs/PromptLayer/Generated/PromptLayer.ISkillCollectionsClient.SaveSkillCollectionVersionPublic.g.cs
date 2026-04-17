#nullable enable

namespace PromptLayer
{
    public partial interface ISkillCollectionsClient
    {
        /// <summary>
        /// Save Skill Collection Version
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.SaveSkillCollectionVersionResponse> SaveSkillCollectionVersionPublicAsync(
            string identifier,

            global::PromptLayer.SaveSkillCollectionVersionRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save Skill Collection Version
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="fileUpdates">
        /// Default Value: []
        /// </param>
        /// <param name="moves">
        /// Default Value: []
        /// </param>
        /// <param name="deletes">
        /// Default Value: []
        /// </param>
        /// <param name="commitMessage"></param>
        /// <param name="releaseLabel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.SaveSkillCollectionVersionResponse> SaveSkillCollectionVersionPublicAsync(
            string identifier,
            global::System.Collections.Generic.IList<global::PromptLayer.FileUpdate>? fileUpdates = default,
            global::System.Collections.Generic.IList<global::PromptLayer.FileMove>? moves = default,
            global::System.Collections.Generic.IList<string>? deletes = default,
            string? commitMessage = default,
            string? releaseLabel = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}