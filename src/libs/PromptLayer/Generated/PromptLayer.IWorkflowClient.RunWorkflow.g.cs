#nullable enable

namespace PromptLayer
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Run Workflow
        /// </summary>
        /// <param name="workflowName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.RunWorkflowResponse> RunWorkflowAsync(
            string workflowName,

            global::PromptLayer.RunWorkflow request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Workflow
        /// </summary>
        /// <param name="workflowName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.RunWorkflowResponse>> RunWorkflowAsResponseAsync(
            string workflowName,

            global::PromptLayer.RunWorkflow request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Workflow
        /// </summary>
        /// <param name="workflowName"></param>
        /// <param name="workflowLabelName">
        /// Specify a workflow label name to run a specific labeled version.
        /// </param>
        /// <param name="workflowVersionNumber">
        /// Specify a workflow version number to run a specific version.
        /// </param>
        /// <param name="metadata">
        /// A dictionary of metadata key-value pairs.
        /// </param>
        /// <param name="inputVariables">
        /// A dictionary of input variables required by the workflow.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="returnAllOutputs">
        /// If set to `true`, all outputs from the workflow execution will be returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.RunWorkflowResponse> RunWorkflowAsync(
            string workflowName,
            string? workflowLabelName = default,
            int? workflowVersionNumber = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            object? inputVariables = default,
            bool? returnAllOutputs = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}