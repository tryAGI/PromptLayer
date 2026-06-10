#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Update Cell<br/>
        /// Edit the value of a text column cell. Only cells in `text` type columns can be edited directly; computed cells are recalculated automatically. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="cellId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateTableSheetCellResponse> UpdateTableSheetCellAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid cellId,

            global::PromptLayer.UpdateTableSheetCellRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cell<br/>
        /// Edit the value of a text column cell. Only cells in `text` type columns can be edited directly; computed cells are recalculated automatically. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="cellId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.UpdateTableSheetCellResponse>> UpdateTableSheetCellAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid cellId,

            global::PromptLayer.UpdateTableSheetCellRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cell<br/>
        /// Edit the value of a text column cell. Only cells in `text` type columns can be edited directly; computed cells are recalculated automatically. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="cellId"></param>
        /// <param name="displayValue">
        /// Human-readable display value.
        /// </param>
        /// <param name="value">
        /// Structured value to store.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateTableSheetCellResponse> UpdateTableSheetCellAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid cellId,
            string? displayValue = default,
            object? value = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}