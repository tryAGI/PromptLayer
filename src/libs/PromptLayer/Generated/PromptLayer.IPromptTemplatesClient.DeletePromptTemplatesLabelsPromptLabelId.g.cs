#nullable enable

namespace PromptLayer
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Delete Prompt Template Label
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePromptTemplatesLabelsPromptLabelIdAsync(
            int promptLabelId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}