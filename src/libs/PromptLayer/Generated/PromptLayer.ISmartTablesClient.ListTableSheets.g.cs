#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// List Sheets<br/>
        /// List all sheets in a table, ordered by their index.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="promptId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListTableSheetsResponse> ListTableSheetsAsync(
            global::System.Guid tableId,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.ListTableSheetsOrder? order = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Sheets<br/>
        /// List all sheets in a table, ordered by their index.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="promptId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListTableSheetsResponse>> ListTableSheetsAsResponseAsync(
            global::System.Guid tableId,
            string? cursor = default,
            int? limit = default,
            global::PromptLayer.ListTableSheetsOrder? order = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}