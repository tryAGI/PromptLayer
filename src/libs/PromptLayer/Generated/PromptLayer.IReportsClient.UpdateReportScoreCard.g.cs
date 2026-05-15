#nullable enable

namespace PromptLayer
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Configure Custom Scoring
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateReportScoreCardResponse> UpdateReportScoreCardAsync(
            int reportId,

            global::PromptLayer.UpdateReportScoreCardRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure Custom Scoring
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.UpdateReportScoreCardResponse>> UpdateReportScoreCardAsResponseAsync(
            int reportId,

            global::PromptLayer.UpdateReportScoreCardRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure Custom Scoring
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="columnNames">
        /// Column names to include in the score calculation.
        /// </param>
        /// <param name="code">
        /// Optional custom Python or JavaScript scoring code. The code receives data and must return an object with a score key.
        /// </param>
        /// <param name="codeLanguage">
        /// Language used by the custom scoring code.<br/>
        /// Default Value: PYTHON
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateReportScoreCardResponse> UpdateReportScoreCardAsync(
            int reportId,
            global::System.Collections.Generic.IList<string> columnNames,
            string? code = default,
            global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage? codeLanguage = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}