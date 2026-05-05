#nullable enable

namespace PromptLayer
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// List Evaluations
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="name"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="includeRuns">
        /// Default Value: false
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListEvaluationsResponse> ListEvaluationsAsync(
            int? workspaceId = default,
            string? name = default,
            global::PromptLayer.ListEvaluationsStatus? status = default,
            bool? includeRuns = default,
            int? page = default,
            int? perPage = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Evaluations
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="name"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="includeRuns">
        /// Default Value: false
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListEvaluationsResponse>> ListEvaluationsAsResponseAsync(
            int? workspaceId = default,
            string? name = default,
            global::PromptLayer.ListEvaluationsStatus? status = default,
            bool? includeRuns = default,
            int? page = default,
            int? perPage = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}