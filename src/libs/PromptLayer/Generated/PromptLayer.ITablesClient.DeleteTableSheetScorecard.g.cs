#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Delete Table Sheet Scorecard<br/>
        /// Soft-delete the active scorecard for a table sheet.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DeleteTableSheetScorecardResponse> DeleteTableSheetScorecardAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Table Sheet Scorecard<br/>
        /// Soft-delete the active scorecard for a table sheet.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.DeleteTableSheetScorecardResponse>> DeleteTableSheetScorecardAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}