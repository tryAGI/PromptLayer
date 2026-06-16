#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// List Table Sheet Versions<br/>
        /// List saved versions for a Table sheet. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="sort">
        /// Default Value: version_number
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListTableSheetVersionsResponse> ListTableSheetVersionsAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.ListTableSheetVersionsSort? sort = default,
            global::PromptLayer.ListTableSheetVersionsOrder? order = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Table Sheet Versions<br/>
        /// List saved versions for a Table sheet. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="sort">
        /// Default Value: version_number
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListTableSheetVersionsResponse>> ListTableSheetVersionsAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.ListTableSheetVersionsSort? sort = default,
            global::PromptLayer.ListTableSheetVersionsOrder? order = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}