#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Create Sheet<br/>
        /// Create a new sheet in a table. Omit source to create a blank sheet with a default Column A scaffold (returns 201), or import data from a file (CSV or JSON, base64-encoded) or from request log history (returns 202). Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableSheetResponse> CreateTableSheetAsync(
            global::System.Guid tableId,

            global::PromptLayer.CreateTableSheetRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Sheet<br/>
        /// Create a new sheet in a table. Omit source to create a blank sheet with a default Column A scaffold (returns 201), or import data from a file (CSV or JSON, base64-encoded) or from request log history (returns 202). Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateTableSheetResponse>> CreateTableSheetAsResponseAsync(
            global::System.Guid tableId,

            global::PromptLayer.CreateTableSheetRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Sheet<br/>
        /// Create a new sheet in a table. Omit source to create a blank sheet with a default Column A scaffold (returns 201), or import data from a file (CSV or JSON, base64-encoded) or from request log history (returns 202). Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="title">
        /// Sheet title. Defaults to 'Sheet N' when source is omitted, or to the source file name / 'Request Logs' for imports.
        /// </param>
        /// <param name="index">
        /// Display position within the table (0-based). Defaults to appending at the end.
        /// </param>
        /// <param name="operationId">
        /// Optional idempotency key for import operations. Not allowed when source is omitted.
        /// </param>
        /// <param name="source">
        /// Optional data source for the sheet. Omit to create a blank sheet with a default Column A scaffold.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableSheetResponse> CreateTableSheetAsync(
            global::System.Guid tableId,
            string? title = default,
            int? index = default,
            string? operationId = default,
            global::PromptLayer.OneOf<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>? source = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}