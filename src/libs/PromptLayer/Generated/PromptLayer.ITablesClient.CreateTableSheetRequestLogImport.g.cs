#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Import Request Logs Into Table Sheet<br/>
        /// Start an asynchronous request-history import into an existing Table sheet. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.TableSheetImportStartResponse> CreateTableSheetRequestLogImportAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.CreateTableSheetRequestLogImportRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Request Logs Into Table Sheet<br/>
        /// Start an asynchronous request-history import into an existing Table sheet. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.TableSheetImportStartResponse>> CreateTableSheetRequestLogImportAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.CreateTableSheetRequestLogImportRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Request Logs Into Table Sheet<br/>
        /// Start an asynchronous request-history import into an existing Table sheet. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="filterGroup">
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </param>
        /// <param name="q">
        /// Free-text request-log search query applied with filter_group.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort matching request logs before import.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Must be provided together with sort_by.
        /// </param>
        /// <param name="metadataCostBreakdownKey">
        /// Request-log query metadata key used by shared request-log query payloads.
        /// </param>
        /// <param name="operationId">
        /// Optional client-provided operation ID. A UUID is generated when omitted.
        /// </param>
        /// <param name="requestLogIds">
        /// Specific request log IDs to import.
        /// </param>
        /// <param name="variablesToParse">
        /// Input variable names to parse from matching request logs.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="includeFields">
        /// Additional request log fields to include as columns.
        /// </param>
        /// <param name="limit">
        /// Maximum number of matching request logs to import.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.TableSheetImportStartResponse> CreateTableSheetRequestLogImportAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::PromptLayer.StructuredFilterGroup? filterGroup = default,
            string? q = default,
            global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy? sortBy = default,
            global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder? sortOrder = default,
            string? metadataCostBreakdownKey = default,
            string? operationId = default,
            global::System.Collections.Generic.IList<int>? requestLogIds = default,
            global::System.Collections.Generic.IList<string>? variablesToParse = default,
            global::System.Collections.Generic.IList<string>? includeFields = default,
            int? limit = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}