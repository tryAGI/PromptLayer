#nullable enable

namespace PromptLayer
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Delete Evaluation Pipeline<br/>
        /// Archive a single evaluation pipeline by ID. Prefer this over deleteReportsByName when you have the report's ID, since names can collide.
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DeleteReportResponse> DeleteReportAsync(
            int reportId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Evaluation Pipeline<br/>
        /// Archive a single evaluation pipeline by ID. Prefer this over deleteReportsByName when you have the report's ID, since names can collide.
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.DeleteReportResponse>> DeleteReportAsResponseAsync(
            int reportId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}