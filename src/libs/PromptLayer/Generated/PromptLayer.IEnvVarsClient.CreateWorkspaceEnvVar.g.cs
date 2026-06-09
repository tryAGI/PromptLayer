#nullable enable

namespace PromptLayer
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Create Workspace Env Var
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateWorkspaceEnvVarResponse> CreateWorkspaceEnvVarAsync(

            global::PromptLayer.CreateWorkspaceEnvVarRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Env Var
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateWorkspaceEnvVarResponse>> CreateWorkspaceEnvVarAsResponseAsync(

            global::PromptLayer.CreateWorkspaceEnvVarRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Env Var
        /// </summary>
        /// <param name="key">
        /// Environment variable name. Must start with a letter or underscore and contain only letters, digits, and underscores.
        /// </param>
        /// <param name="value">
        /// Value to store. May be empty to create a placeholder that the user will fill in later.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateWorkspaceEnvVarResponse> CreateWorkspaceEnvVarAsync(
            string key,
            string? value = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}