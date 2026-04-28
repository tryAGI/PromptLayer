#nullable enable

namespace PromptLayer
{
    public partial interface IToolRegistryClient
    {
        /// <summary>
        /// Get Tool Registry<br/>
        /// Get a tool from the Tool Registry by ID or name. Optionally resolve a specific version by label or version number.
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="label">
        /// Resolve version by label name (e.g. production)
        /// </param>
        /// <param name="version">
        /// Resolve by specific version number
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.GetToolRegistryResponse> GetToolRegistryAsync(
            string identifier,
            string? label = default,
            string? version = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}