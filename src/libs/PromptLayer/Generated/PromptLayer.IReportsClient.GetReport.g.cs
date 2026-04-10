#nullable enable

namespace PromptLayer
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Get Evaluation
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.GetReportResponse> GetReportAsync(
            int reportId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}