#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Delete Column<br/>
        /// Delete a column and its cells. The operation creates a new sheet version and may mark downstream dependent cells as stale. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="columnId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DeleteTableSheetColumnResponse> DeleteTableSheetColumnAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid columnId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Column<br/>
        /// Delete a column and its cells. The operation creates a new sheet version and may mark downstream dependent cells as stale. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="columnId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.DeleteTableSheetColumnResponse>> DeleteTableSheetColumnAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid columnId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}