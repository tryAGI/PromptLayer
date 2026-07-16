#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Cancel Table Sheet Scorecard<br/>
        /// Cancel active queued or running scorecard work for a table sheet.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CancelTableSheetScorecardResponse> CancelTableSheetScorecardAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.CancelTableSheetScorecardRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Table Sheet Scorecard<br/>
        /// Cancel active queued or running scorecard work for a table sheet.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CancelTableSheetScorecardResponse>> CancelTableSheetScorecardAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.CancelTableSheetScorecardRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Table Sheet Scorecard<br/>
        /// Cancel active queued or running scorecard work for a table sheet.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="rowIndices"></param>
        /// <param name="stepIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CancelTableSheetScorecardResponse> CancelTableSheetScorecardAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::System.Collections.Generic.IList<int>? rowIndices = default,
            global::System.Collections.Generic.IList<global::System.Guid>? stepIds = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}