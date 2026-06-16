#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Create Table Sheet Operation<br/>
        /// Queue a recalculation operation for selected columns, rows, and cell statuses. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableSheetOperationResponse> CreateTableSheetOperationAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.CreateTableSheetOperationRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Table Sheet Operation<br/>
        /// Queue a recalculation operation for selected columns, rows, and cell statuses. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateTableSheetOperationResponse>> CreateTableSheetOperationAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.CreateTableSheetOperationRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Table Sheet Operation<br/>
        /// Queue a recalculation operation for selected columns, rows, and cell statuses. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="operation">
        /// Default Value: recalculate
        /// </param>
        /// <param name="columnIds">
        /// Columns to recalculate. Text columns cannot be recalculated.
        /// </param>
        /// <param name="rowIds">
        /// Zero-based row indices to recalculate. If omitted, matching cells across all rows are considered.
        /// </param>
        /// <param name="statuses">
        /// Cell statuses to include. Defaults to stale cells. Pass an empty array to include all statuses.
        /// </param>
        /// <param name="confirmationToken">
        /// Confirmation token returned when the operation exceeds the confirmation threshold.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableSheetOperationResponse> CreateTableSheetOperationAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::PromptLayer.CreateTableSheetOperationRequestOperation? operation = default,
            global::System.Collections.Generic.IList<global::System.Guid>? columnIds = default,
            global::System.Collections.Generic.IList<int>? rowIds = default,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetOperationRequestStatuse>? statuses = default,
            string? confirmationToken = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}