#nullable enable

namespace PromptLayer
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Move Folder Entities<br/>
        /// Moves one or more entities into a target folder, or to the workspace root if no folder_id is provided. Supports moving folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Requires appropriate edit permissions for each entity type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.FolderEntitiesCountResponse> MoveFolderEntitiesApiPublicV2FoldersEntitiesPostAsync(

            global::PromptLayer.MoveFolderEntitiesRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Folder Entities<br/>
        /// Moves one or more entities into a target folder, or to the workspace root if no folder_id is provided. Supports moving folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Requires appropriate edit permissions for each entity type.
        /// </summary>
        /// <param name="entities">
        /// List of entities to move.
        /// </param>
        /// <param name="folderId">
        /// The ID of the destination folder. If null or not provided, entities are moved to the workspace root.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.FolderEntitiesCountResponse> MoveFolderEntitiesApiPublicV2FoldersEntitiesPostAsync(
            global::System.Collections.Generic.IList<global::PromptLayer.EntityReference> entities,
            int? folderId = default,
            int? workspaceId = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}