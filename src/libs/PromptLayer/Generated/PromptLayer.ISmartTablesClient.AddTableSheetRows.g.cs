#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Add Rows<br/>
        /// Append one or more rows to a sheet. Text column values can be set immediately; non-text column cells are created with `stale` status and must be triggered via a recalculation. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AddTableSheetRowsResponse> AddTableSheetRowsAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.AddTableSheetRowsRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Rows<br/>
        /// Append one or more rows to a sheet. Text column values can be set immediately; non-text column cells are created with `stale` status and must be triggered via a recalculation. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.AddTableSheetRowsResponse>> AddTableSheetRowsAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.AddTableSheetRowsRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Rows<br/>
        /// Append one or more rows to a sheet. Text column values can be set immediately; non-text column cells are created with `stale` status and must be triggered via a recalculation. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="count">
        /// Number of rows to append (1–100).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="values">
        /// Per-row initial values for text columns. Each element is a map of column_id → value.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AddTableSheetRowsResponse> AddTableSheetRowsAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            int? count = default,
            global::System.Collections.Generic.IList<object>? values = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}