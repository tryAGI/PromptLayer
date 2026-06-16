#nullable enable

namespace PromptLayer
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Update Tool Env Var
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="varId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateToolEnvVarResponse> UpdateToolEnvVarAsync(
            string identifier,
            int varId,

            global::PromptLayer.UpdateToolEnvVarRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tool Env Var
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="varId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.UpdateToolEnvVarResponse>> UpdateToolEnvVarAsResponseAsync(
            string identifier,
            int varId,

            global::PromptLayer.UpdateToolEnvVarRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tool Env Var
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="varId"></param>
        /// <param name="value">
        /// New value for the environment variable. Must be non-empty.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.UpdateToolEnvVarResponse> UpdateToolEnvVarAsync(
            string identifier,
            int varId,
            string value,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}