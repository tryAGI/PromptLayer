#nullable enable

namespace PromptLayer
{
    public partial interface IToolRegistryClient
    {
        /// <summary>
        /// Create Tool Version
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateToolVersionResponse> CreateToolVersionAsync(
            string identifier,

            global::PromptLayer.CreateToolVersionRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool Version
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateToolVersionResponse>> CreateToolVersionAsResponseAsync(
            string identifier,

            global::PromptLayer.CreateToolVersionRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool Version
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="toolDefinition">
        /// Tool definition in OpenAI function-calling format
        /// </param>
        /// <param name="execution">
        /// Optional sandbox-executable body. When set, PromptLayer auto-runs the body between LLM turns whenever a prompt uses this version. See Auto Tool Execution.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for the new version
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateToolVersionResponse> CreateToolVersionAsync(
            string identifier,
            object toolDefinition,
            global::PromptLayer.CreateToolVersionRequestExecution? execution = default,
            string? commitMessage = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}