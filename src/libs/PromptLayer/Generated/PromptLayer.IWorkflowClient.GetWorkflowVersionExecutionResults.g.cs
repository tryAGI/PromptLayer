#nullable enable

namespace PromptLayer
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Get Workflow Version Execution Results
        /// </summary>
        /// <param name="workflowVersionExecutionId"></param>
        /// <param name="returnAllOutputs">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>> GetWorkflowVersionExecutionResultsAsync(
            long workflowVersionExecutionId,
            bool? returnAllOutputs = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Workflow Version Execution Results
        /// </summary>
        /// <param name="workflowVersionExecutionId"></param>
        /// <param name="returnAllOutputs">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>>> GetWorkflowVersionExecutionResultsAsResponseAsync(
            long workflowVersionExecutionId,
            bool? returnAllOutputs = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}