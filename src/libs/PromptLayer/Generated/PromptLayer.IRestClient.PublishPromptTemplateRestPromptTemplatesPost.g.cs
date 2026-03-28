#nullable enable

namespace PromptLayer
{
    public partial interface IRestClient
    {
        /// <summary>
        /// Publish Prompt Template
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreatePromptTemplateResponse> PublishPromptTemplateRestPromptTemplatesPostAsync(

            global::PromptLayer.CreatePromptTemplate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Prompt Template
        /// </summary>
        /// <param name="promptTemplate"></param>
        /// <param name="promptVersion"></param>
        /// <param name="releaseLabels"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreatePromptTemplateResponse> PublishPromptTemplateRestPromptTemplatesPostAsync(
            global::PromptLayer.BasePromptTemplate promptTemplate,
            global::PromptLayer.PromptVersion promptVersion,
            global::System.Collections.Generic.IList<string>? releaseLabels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}