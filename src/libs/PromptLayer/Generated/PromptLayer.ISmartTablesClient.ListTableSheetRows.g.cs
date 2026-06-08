#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// List Rows<br/>
        /// List rows in a sheet, each containing a map of column_id to cell. For prompt-template column cells, each cell can include a `request_metrics` object with price, latency, and token usage when available. Pass `include_columns=true` on the first page to receive column metadata alongside rows.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="includeSystemColumns">
        /// Default Value: false
        /// </param>
        /// <param name="includeExecutionMetadataAggregates">
        /// Default Value: false
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="includeColumns">
        /// Include column metadata in the response. Defaults to true on the first page.
        /// </param>
        /// <param name="includeRowCount">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListTableSheetRowsResponse> ListTableSheetRowsAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            bool? includeSystemColumns = default,
            bool? includeExecutionMetadataAggregates = default,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.ListTableSheetRowsOrder? order = default,
            bool? includeColumns = default,
            bool? includeRowCount = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Rows<br/>
        /// List rows in a sheet, each containing a map of column_id to cell. For prompt-template column cells, each cell can include a `request_metrics` object with price, latency, and token usage when available. Pass `include_columns=true` on the first page to receive column metadata alongside rows.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="includeSystemColumns">
        /// Default Value: false
        /// </param>
        /// <param name="includeExecutionMetadataAggregates">
        /// Default Value: false
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="includeColumns">
        /// Include column metadata in the response. Defaults to true on the first page.
        /// </param>
        /// <param name="includeRowCount">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListTableSheetRowsResponse>> ListTableSheetRowsAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            bool? includeSystemColumns = default,
            bool? includeExecutionMetadataAggregates = default,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.ListTableSheetRowsOrder? order = default,
            bool? includeColumns = default,
            bool? includeRowCount = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}