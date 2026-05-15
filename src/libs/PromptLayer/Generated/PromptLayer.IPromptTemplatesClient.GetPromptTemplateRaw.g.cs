#nullable enable

namespace PromptLayer
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Get Prompt Template Raw Data
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="version">
        /// Specific version number to retrieve. Mutually exclusive with `label`.
        /// </param>
        /// <param name="label">
        /// Release label name to retrieve (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="resolveSnippets">
        /// When true (default), snippets are expanded in the returned prompt_template. When false, raw @@@snippet@@@ references are preserved.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeLlmKwargs">
        /// When true, includes provider-specific llm_kwargs in the response. Requires model metadata to be set on the template.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.GetPromptTemplateRawResponse> GetPromptTemplateRawAsync(
            string identifier,
            int? version = default,
            string? label = default,
            bool? resolveSnippets = default,
            bool? includeLlmKwargs = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Prompt Template Raw Data
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="version">
        /// Specific version number to retrieve. Mutually exclusive with `label`.
        /// </param>
        /// <param name="label">
        /// Release label name to retrieve (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="resolveSnippets">
        /// When true (default), snippets are expanded in the returned prompt_template. When false, raw @@@snippet@@@ references are preserved.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeLlmKwargs">
        /// When true, includes provider-specific llm_kwargs in the response. Requires model metadata to be set on the template.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.GetPromptTemplateRawResponse>> GetPromptTemplateRawAsResponseAsync(
            string identifier,
            int? version = default,
            string? label = default,
            bool? resolveSnippets = default,
            bool? includeLlmKwargs = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}