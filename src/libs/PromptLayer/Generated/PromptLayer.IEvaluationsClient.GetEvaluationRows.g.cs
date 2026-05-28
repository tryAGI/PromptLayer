#nullable enable

namespace PromptLayer
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Get Evaluation Rows
        /// </summary>
        /// <param name="evaluationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.EvaluationRowsResponse> GetEvaluationRowsAsync(
            int evaluationId,
            int? workspaceId = default,
            int? page = default,
            int? perPage = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Evaluation Rows
        /// </summary>
        /// <param name="evaluationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.EvaluationRowsResponse>> GetEvaluationRowsAsResponseAsync(
            int evaluationId,
            int? workspaceId = default,
            int? page = default,
            int? perPage = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}