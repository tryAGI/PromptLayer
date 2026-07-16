#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// List Table Sheet Scorecard Rows<br/>
        /// List row-level scorecard summaries for a calculation.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="calculationId"></param>
        /// <param name="verdict"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListTableSheetScorecardRowsResponse> ListTableSheetScorecardRowsAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid? calculationId = default,
            global::PromptLayer.ListTableSheetScorecardRowsVerdict? verdict = default,
            int? cursor = default,
            int? limit = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Table Sheet Scorecard Rows<br/>
        /// List row-level scorecard summaries for a calculation.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="calculationId"></param>
        /// <param name="verdict"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListTableSheetScorecardRowsResponse>> ListTableSheetScorecardRowsAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Guid? calculationId = default,
            global::PromptLayer.ListTableSheetScorecardRowsVerdict? verdict = default,
            int? cursor = default,
            int? limit = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}