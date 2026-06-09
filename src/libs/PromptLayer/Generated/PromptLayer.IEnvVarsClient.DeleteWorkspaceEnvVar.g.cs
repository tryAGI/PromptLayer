#nullable enable

namespace PromptLayer
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Delete Workspace Env Var
        /// </summary>
        /// <param name="varId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.DeleteWorkspaceEnvVarResponse> DeleteWorkspaceEnvVarAsync(
            int varId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Workspace Env Var
        /// </summary>
        /// <param name="varId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.DeleteWorkspaceEnvVarResponse>> DeleteWorkspaceEnvVarAsResponseAsync(
            int varId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}