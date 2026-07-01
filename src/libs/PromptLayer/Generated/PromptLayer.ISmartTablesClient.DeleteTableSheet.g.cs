#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Delete Sheet<br/>
        /// Delete a sheet. This soft deletes the sheet and removes it from active sheet list responses. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DeleteTableSheetResponse> DeleteTableSheetAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Sheet<br/>
        /// Delete a sheet. This soft deletes the sheet and removes it from active sheet list responses. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.DeleteTableSheetResponse>> DeleteTableSheetAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}