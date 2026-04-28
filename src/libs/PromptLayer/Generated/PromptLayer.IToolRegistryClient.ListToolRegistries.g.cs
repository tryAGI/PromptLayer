#nullable enable

namespace PromptLayer
{
    public partial interface IToolRegistryClient
    {
        /// <summary>
        /// List Tool Registries<br/>
        /// List all tools in the Tool Registry for the workspace.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListToolRegistriesResponse> ListToolRegistriesAsync(
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}