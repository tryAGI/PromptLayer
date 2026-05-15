#nullable enable

namespace PromptLayer
{
    public partial interface IToolRegistryClient
    {
        /// <summary>
        /// Create Tool Registry
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateToolRegistryResponse> CreateToolRegistryAsync(

            global::PromptLayer.CreateToolRegistryRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool Registry
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateToolRegistryResponse>> CreateToolRegistryAsResponseAsync(

            global::PromptLayer.CreateToolRegistryRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool Registry
        /// </summary>
        /// <param name="name">
        /// Tool name (unique per workspace)
        /// </param>
        /// <param name="toolDefinition">
        /// Tool definition in OpenAI function-calling format
        /// </param>
        /// <param name="folderId">
        /// Folder ID to place tool in
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for the initial version
        /// </param>
        /// <param name="externalIds">
        /// Identifiers from other systems.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateToolRegistryResponse> CreateToolRegistryAsync(
            string name,
            object toolDefinition,
            int? folderId = default,
            string? commitMessage = default,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}