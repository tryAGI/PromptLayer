#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Create Sheet<br/>
        /// Create a new sheet in a table by importing data from a file (CSV or JSON, base64-encoded) or from request log history.
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
        /// Create a new sheet in a table by importing data from a file (CSV or JSON, base64-encoded) or from request log history.
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
        /// Create a new sheet in a table by importing data from a file (CSV or JSON, base64-encoded) or from request log history.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="title">
        /// Sheet title. Defaults to the source file name or 'Request Logs'.
        /// </param>
        /// <param name="index">
        /// Display position within the table (0-based). Defaults to appending at the end.
        /// </param>
        /// <param name="operationId">
        /// Optional idempotency key for the import operation.
        /// </param>
        /// <param name="source">
        /// Data source for the sheet.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableSheetResponse> CreateTableSheetAsync(
            global::System.Guid tableId,
            global::PromptLayer.OneOf<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource> source,
            string? title = default,
            int? index = default,
            string? operationId = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}