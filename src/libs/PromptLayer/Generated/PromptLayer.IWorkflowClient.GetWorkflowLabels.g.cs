#nullable enable

namespace PromptLayer
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Get Agent Labels
        /// </summary>
        /// <param name="workflowIdOrName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.GetWorkflowLabelsResponse> GetWorkflowLabelsAsync(
            string workflowIdOrName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}