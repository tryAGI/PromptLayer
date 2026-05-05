#nullable enable

namespace PromptLayer
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="label"></param>
        /// <param name="name"></param>
        /// <param name="tags"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ListPromptTemplates> GetAllPromptTemplatesGetAsync(
            int? page = default,
            int? perPage = default,
            string? label = default,
            string? name = default,
            global::PromptLayer.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            global::PromptLayer.GetAllPromptTemplatesGetStatus? status = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="label"></param>
        /// <param name="name"></param>
        /// <param name="tags"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ListPromptTemplates>> GetAllPromptTemplatesGetAsResponseAsync(
            int? page = default,
            int? perPage = default,
            string? label = default,
            string? name = default,
            global::PromptLayer.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            global::PromptLayer.GetAllPromptTemplatesGetStatus? status = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}