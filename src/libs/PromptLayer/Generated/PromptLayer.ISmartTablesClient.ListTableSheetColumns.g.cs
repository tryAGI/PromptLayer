#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// List Columns<br/>
        /// List columns in a sheet, ordered by position rank. By default, system-managed metadata columns such as price and latency columns are excluded; pass `include_system_columns=true` to include them.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="includeSystemColumns">
        /// Default Value: false
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListTableSheetColumnsResponse> ListTableSheetColumnsAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            bool? includeSystemColumns = default,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Columns<br/>
        /// List columns in a sheet, ordered by position rank. By default, system-managed metadata columns such as price and latency columns are excluded; pass `include_system_columns=true` to include them.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="includeSystemColumns">
        /// Default Value: false
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListTableSheetColumnsResponse>> ListTableSheetColumnsAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            bool? includeSystemColumns = default,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}