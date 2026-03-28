#nullable enable

namespace PromptLayer
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Move Prompt Template Labels
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchResponse> PromptTemplatesLabelsPromptLabelIdPatchAsync(
            int promptLabelId,

            global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Prompt Template Labels
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="promptVersionNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchResponse> PromptTemplatesLabelsPromptLabelIdPatchAsync(
            int promptLabelId,
            int promptVersionNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}