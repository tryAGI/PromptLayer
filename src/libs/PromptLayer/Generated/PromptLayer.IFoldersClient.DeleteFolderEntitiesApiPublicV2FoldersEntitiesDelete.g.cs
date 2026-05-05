#nullable enable

namespace PromptLayer
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Delete Folder Entities<br/>
        /// Deletes one or more entities from the workspace. Supports deleting folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Use cascade=true to recursively delete all contents of a folder. Without cascade, deleting a non-empty folder returns an error. Entities are soft-deleted where applicable.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.FolderEntitiesCountResponse> DeleteFolderEntitiesApiPublicV2FoldersEntitiesDeleteAsync(

            global::PromptLayer.DeleteFolderEntitiesRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Folder Entities<br/>
        /// Deletes one or more entities from the workspace. Supports deleting folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Use cascade=true to recursively delete all contents of a folder. Without cascade, deleting a non-empty folder returns an error. Entities are soft-deleted where applicable.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.FolderEntitiesCountResponse>> DeleteFolderEntitiesApiPublicV2FoldersEntitiesDeleteAsResponseAsync(

            global::PromptLayer.DeleteFolderEntitiesRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Folder Entities<br/>
        /// Deletes one or more entities from the workspace. Supports deleting folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Use cascade=true to recursively delete all contents of a folder. Without cascade, deleting a non-empty folder returns an error. Entities are soft-deleted where applicable.
        /// </summary>
        /// <param name="entities">
        /// List of entities to delete.
        /// </param>
        /// <param name="cascade">
        /// When true, recursively deletes all contents of any folders in the entities list. When false, attempting to delete a non-empty folder returns an error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.FolderEntitiesCountResponse> DeleteFolderEntitiesApiPublicV2FoldersEntitiesDeleteAsync(
            global::System.Collections.Generic.IList<global::PromptLayer.EntityReference> entities,
            bool? cascade = default,
            int? workspaceId = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}