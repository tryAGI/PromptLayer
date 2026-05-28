#nullable enable

namespace PromptLayer
{
    public partial interface IToolRegistryClient
    {
        /// <summary>
        /// Test Execute Tool
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="label">
        /// Resolve version by label name (e.g. production). Falls back to latest if neither label nor version supplied.
        /// </param>
        /// <param name="version">
        /// Resolve by specific version number
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.TestExecuteToolResponse> TestExecuteToolAsync(
            string identifier,

            global::PromptLayer.TestExecuteToolRequest request,
            string? label = default,
            string? version = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Execute Tool
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="label">
        /// Resolve version by label name (e.g. production). Falls back to latest if neither label nor version supplied.
        /// </param>
        /// <param name="version">
        /// Resolve by specific version number
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.TestExecuteToolResponse>> TestExecuteToolAsResponseAsync(
            string identifier,

            global::PromptLayer.TestExecuteToolRequest request,
            string? label = default,
            string? version = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Execute Tool
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="label">
        /// Resolve version by label name (e.g. production). Falls back to latest if neither label nor version supplied.
        /// </param>
        /// <param name="version">
        /// Resolve by specific version number
        /// </param>
        /// <param name="inputs">
        /// Arguments passed to the tool body. Same shape the LLM would emit — keys match the tool's parameter names.
        /// </param>
        /// <param name="execution">
        /// In-flight override of the stored execution config. Lets you test unsaved code.
        /// </param>
        /// <param name="toolDefinition">
        /// In-flight override of the stored tool definition. Used to test against a different function name without saving.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.TestExecuteToolResponse> TestExecuteToolAsync(
            string identifier,
            string? label = default,
            string? version = default,
            object? inputs = default,
            global::PromptLayer.TestExecuteToolRequestExecution? execution = default,
            object? toolDefinition = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}