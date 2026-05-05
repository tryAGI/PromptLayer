#nullable enable

namespace PromptLayer
{
    public partial interface ISkillCollectionsClient
    {
        /// <summary>
        /// Create Skill Collection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateSkillCollectionResponse> CreateSkillCollectionPublicAsync(

            global::PromptLayer.CreateSkillCollectionRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Skill Collection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateSkillCollectionResponse>> CreateSkillCollectionPublicAsResponseAsync(

            global::PromptLayer.CreateSkillCollectionRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Skill Collection
        /// </summary>
        /// <param name="name"></param>
        /// <param name="folderId"></param>
        /// <param name="provider"></param>
        /// <param name="files">
        /// Default Value: []
        /// </param>
        /// <param name="commitMessage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateSkillCollectionResponse> CreateSkillCollectionPublicAsync(
            string name,
            int? folderId = default,
            string? provider = default,
            global::System.Collections.Generic.IList<global::PromptLayer.InitialFileUpdate>? files = default,
            string? commitMessage = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}