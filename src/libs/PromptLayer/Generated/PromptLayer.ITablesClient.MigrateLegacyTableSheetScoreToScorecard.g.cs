#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Migrate Legacy Score to Scorecard<br/>
        /// Convert legacy sheet score configuration into scorecard criteria.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.MigrateLegacyTableSheetScoreResponse> MigrateLegacyTableSheetScoreToScorecardAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.MigrateLegacyTableSheetScoreRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Migrate Legacy Score to Scorecard<br/>
        /// Convert legacy sheet score configuration into scorecard criteria.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.MigrateLegacyTableSheetScoreResponse>> MigrateLegacyTableSheetScoreToScorecardAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.MigrateLegacyTableSheetScoreRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Migrate Legacy Score to Scorecard<br/>
        /// Convert legacy sheet score configuration into scorecard criteria.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="deleteLegacyScore">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.MigrateLegacyTableSheetScoreResponse> MigrateLegacyTableSheetScoreToScorecardAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            bool? deleteLegacyScore = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}