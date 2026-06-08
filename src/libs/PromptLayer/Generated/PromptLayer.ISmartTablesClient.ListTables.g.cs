#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// List Tables<br/>
        /// List Tables in the workspace. Supports cursor-based pagination and optional filtering by folder or prompt column.
        /// </summary>
        /// <param name="folderId">
        /// Filter by folder ID.
        /// </param>
        /// <param name="name">
        /// Filter by title (case-insensitive contains match).
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response.
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="promptId">
        /// Filter to tables containing a column referencing this prompt.
        /// </param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListTablesResponse> ListTablesAsync(
            int? folderId = default,
            string? name = default,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.ListTablesOrder? order = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tables<br/>
        /// List Tables in the workspace. Supports cursor-based pagination and optional filtering by folder or prompt column.
        /// </summary>
        /// <param name="folderId">
        /// Filter by folder ID.
        /// </param>
        /// <param name="name">
        /// Filter by title (case-insensitive contains match).
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response.
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="promptId">
        /// Filter to tables containing a column referencing this prompt.
        /// </param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListTablesResponse>> ListTablesAsResponseAsync(
            int? folderId = default,
            string? name = default,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.ListTablesOrder? order = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}