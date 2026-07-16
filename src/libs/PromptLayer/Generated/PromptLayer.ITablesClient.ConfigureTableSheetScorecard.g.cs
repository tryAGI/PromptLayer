#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Configure Table Sheet Scorecard<br/>
        /// Create or update the active scorecard for a table sheet.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ConfigureTableSheetScorecardResponse> ConfigureTableSheetScorecardAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.ConfigureTableSheetScorecardRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure Table Sheet Scorecard<br/>
        /// Create or update the active scorecard for a table sheet.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ConfigureTableSheetScorecardResponse>> ConfigureTableSheetScorecardAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.ConfigureTableSheetScorecardRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure Table Sheet Scorecard<br/>
        /// Create or update the active scorecard for a table sheet.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="name"></param>
        /// <param name="evaluatedColumnIds">
        /// Default Value: []
        /// </param>
        /// <param name="steps">
        /// Default Value: []
        /// </param>
        /// <param name="aggregation"></param>
        /// <param name="displayConfig"></param>
        /// <param name="baselineConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ConfigureTableSheetScorecardResponse> ConfigureTableSheetScorecardAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            string name,
            object aggregation,
            global::System.Collections.Generic.IList<string>? evaluatedColumnIds = default,
            global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardStep>? steps = default,
            object? displayConfig = default,
            object? baselineConfig = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}