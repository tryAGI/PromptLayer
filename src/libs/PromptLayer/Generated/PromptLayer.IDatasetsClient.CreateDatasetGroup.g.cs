#nullable enable

namespace PromptLayer
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetGroupResponse> CreateDatasetGroupAsync(

            global::PromptLayer.CreateDatasetGroupRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateDatasetGroupResponse>> CreateDatasetGroupAsResponseAsync(

            global::PromptLayer.CreateDatasetGroupRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Group
        /// </summary>
        /// <param name="name">
        /// Name for the dataset group. Must be unique within the workspace.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID. Defaults to the workspace associated with the API key.
        /// </param>
        /// <param name="folderId">
        /// Folder ID to create the dataset group in. Omit to create at the workspace root.
        /// </param>
        /// <param name="externalIds">
        /// External ID mappings to attach to the dataset group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetGroupResponse> CreateDatasetGroupAsync(
            string name,
            int? workspaceId = default,
            int? folderId = default,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}