#nullable enable

namespace PromptLayer
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create a new label for a prompt
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreatePromptLabelResponse> CreatePromptLabelAsync(
            int promptId,

            global::PromptLayer.CreatePromptLabelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new label for a prompt
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="promptVersionNumber"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreatePromptLabelResponse> CreatePromptLabelAsync(
            int promptId,
            int promptVersionNumber,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}