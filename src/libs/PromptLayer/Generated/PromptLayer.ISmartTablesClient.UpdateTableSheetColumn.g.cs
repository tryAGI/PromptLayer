#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Update Column<br/>
        /// Update a column's title, config, or dependencies. Returns `requires_recalculation: true` when the change invalidates existing cell values. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="columnId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateTableSheetColumnResponse> UpdateTableSheetColumnAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid columnId,

            global::PromptLayer.UpdateTableSheetColumnRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Column<br/>
        /// Update a column's title, config, or dependencies. Returns `requires_recalculation: true` when the change invalidates existing cell values. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="columnId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.UpdateTableSheetColumnResponse>> UpdateTableSheetColumnAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid columnId,

            global::PromptLayer.UpdateTableSheetColumnRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Column<br/>
        /// Update a column's title, config, or dependencies. Returns `requires_recalculation: true` when the change invalidates existing cell values. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="columnId"></param>
        /// <param name="title"></param>
        /// <param name="config"></param>
        /// <param name="dependencies"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateTableSheetColumnResponse> UpdateTableSheetColumnAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid columnId,
            string? title = default,
            object? config = default,
            global::System.Collections.Generic.IList<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>? dependencies = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}