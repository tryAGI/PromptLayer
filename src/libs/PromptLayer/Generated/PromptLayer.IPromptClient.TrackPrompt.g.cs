#nullable enable

namespace PromptLayer
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Track Prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.TrackResponse> TrackPromptAsync(

            global::PromptLayer.TrackPromptRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Track Prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.TrackResponse>> TrackPromptAsResponseAsync(

            global::PromptLayer.TrackPromptRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Track Prompt
        /// </summary>
        /// <param name="promptName">
        /// Prompt template name to associate with the request.
        /// </param>
        /// <param name="promptInputVariables">
        /// Variables used to render the prompt.
        /// </param>
        /// <param name="requestId">
        /// PromptLayer request ID to update.
        /// </param>
        /// <param name="version">
        /// Prompt template version to associate.
        /// </param>
        /// <param name="label">
        /// Release label to resolve to a prompt template version.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.TrackResponse> TrackPromptAsync(
            string promptName,
            global::PromptLayer.AnyOf<int?, string> requestId,
            object? promptInputVariables = default,
            global::PromptLayer.AnyOf<int?, string, object>? version = default,
            string? label = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}