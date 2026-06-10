#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Get Table Sheet Score History<br/>
        /// Retrieve score-history points across Table sheet versions. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="maxPoints">
        /// Default Value: 1200
        /// </param>
        /// <param name="range">
        /// Default Value: all
        /// </param>
        /// <param name="resolution">
        /// Default Value: auto
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.TableSheetScoreHistoryResponse> GetTableSheetVersionScoreHistoryAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            int? maxPoints = default,
            global::PromptLayer.GetTableSheetVersionScoreHistoryRange? range = default,
            global::PromptLayer.GetTableSheetVersionScoreHistoryResolution? resolution = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Table Sheet Score History<br/>
        /// Retrieve score-history points across Table sheet versions. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="maxPoints">
        /// Default Value: 1200
        /// </param>
        /// <param name="range">
        /// Default Value: all
        /// </param>
        /// <param name="resolution">
        /// Default Value: auto
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.TableSheetScoreHistoryResponse>> GetTableSheetVersionScoreHistoryAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            int? maxPoints = default,
            global::PromptLayer.GetTableSheetVersionScoreHistoryRange? range = default,
            global::PromptLayer.GetTableSheetVersionScoreHistoryResolution? resolution = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}