#nullable enable

namespace PromptLayer
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Delete Tool Env Var
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="varId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DeleteToolEnvVarResponse> DeleteToolEnvVarAsync(
            string identifier,
            int varId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Tool Env Var
        /// </summary>
        /// <param name="identifier">
        /// Tool ID (numeric) or name
        /// </param>
        /// <param name="varId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.DeleteToolEnvVarResponse>> DeleteToolEnvVarAsResponseAsync(
            string identifier,
            int varId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}