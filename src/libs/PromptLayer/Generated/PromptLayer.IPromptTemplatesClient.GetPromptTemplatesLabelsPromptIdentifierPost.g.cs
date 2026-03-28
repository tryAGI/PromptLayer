#nullable enable

namespace PromptLayer
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Get Prompt Template Labels
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.GetPromptTemplateLabelResponse> GetPromptTemplatesLabelsPromptIdentifierPostAsync(
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}