#nullable enable

namespace PromptLayer
{
    public partial interface IRestClient
    {
        /// <summary>
        /// Patch Prompt Template Version
        /// </summary>
        /// <param name="identifier">
        /// The prompt template name or ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreatePromptTemplateResponse> PatchPromptTemplateVersionAsync(
            string identifier,

            global::PromptLayer.PatchPromptTemplateVersion request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Prompt Template Version
        /// </summary>
        /// <param name="identifier">
        /// The prompt template name or ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreatePromptTemplateResponse>> PatchPromptTemplateVersionAsResponseAsync(
            string identifier,

            global::PromptLayer.PatchPromptTemplateVersion request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Prompt Template Version
        /// </summary>
        /// <param name="identifier">
        /// The prompt template name or ID.
        /// </param>
        /// <param name="version">
        /// The base version number to patch from. Mutually exclusive with `label`. If neither is provided, the latest version is used.
        /// </param>
        /// <param name="label">
        /// The release label identifying the base version to patch from (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="messages">
        /// Patch for chat template messages. Object keys are message indexes for index-based patching; arrays replace all messages.
        /// </param>
        /// <param name="tools">
        /// Patch for tools. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </param>
        /// <param name="functions">
        /// Patch for functions. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </param>
        /// <param name="functionCall">
        /// Replace the function_call setting. Set to null to remove. Chat templates only.
        /// </param>
        /// <param name="toolChoice">
        /// Replace the tool_choice setting. Set to null to remove. Chat templates only.
        /// </param>
        /// <param name="content">
        /// Patch for completion template content. Object for index-based patching, array for full replacement. Completion templates only.
        /// </param>
        /// <param name="modelParameters">
        /// Parameters to shallow-merge into existing model parameters. Existing keys not provided are preserved.
        /// </param>
        /// <param name="responseFormat">
        /// Convenience field to set response_format in model parameters. Cannot be used simultaneously with response_format inside model_parameters. Set to null to remove.
        /// </param>
        /// <param name="commitMessage">
        /// A message describing the changes in this version.
        /// </param>
        /// <param name="releaseLabels">
        /// Release labels to create or move to the newly created version.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreatePromptTemplateResponse> PatchPromptTemplateVersionAsync(
            string identifier,
            int? version = default,
            string? label = default,
            global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? messages = default,
            global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? tools = default,
            global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? functions = default,
            global::PromptLayer.AnyOf<string, object, object>? functionCall = default,
            global::PromptLayer.AnyOf<string, object, object>? toolChoice = default,
            global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? content = default,
            object? modelParameters = default,
            object? responseFormat = default,
            string? commitMessage = default,
            global::System.Collections.Generic.IList<string>? releaseLabels = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}