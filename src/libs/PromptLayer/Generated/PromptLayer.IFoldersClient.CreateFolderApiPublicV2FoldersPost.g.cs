#nullable enable

namespace PromptLayer
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Create Folder
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateFolderSuccessResponse> CreateFolderApiPublicV2FoldersPostAsync(

            global::PromptLayer.CreateFolderRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateFolderSuccessResponse>> CreateFolderApiPublicV2FoldersPostAsResponseAsync(

            global::PromptLayer.CreateFolderRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder
        /// </summary>
        /// <param name="name">
        /// The name of the folder. Must be unique within its parent folder.
        /// </param>
        /// <param name="parentId">
        /// The ID of the parent folder. If null or not provided, the folder will be created at the root level of the workspace.
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID. If not provided, uses the workspace associated with your API key.
        /// </param>
        /// <param name="externalIds">
        /// Identifiers from other systems.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateFolderSuccessResponse> CreateFolderApiPublicV2FoldersPostAsync(
            string name,
            int? parentId = default,
            int? workspaceId = default,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}