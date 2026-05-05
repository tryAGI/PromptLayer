#nullable enable

namespace PromptLayer
{
    public partial interface ITrackingClient
    {
        /// <summary>
        /// Search Request Suggestions
        /// </summary>
        /// <param name="field"></param>
        /// <param name="prefix"></param>
        /// <param name="metadataKey"></param>
        /// <param name="promptId"></param>
        /// <param name="filterGroup"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.GetRequestSearchSuggestionsResponse> GetRequestSearchSuggestionsAsync(
            global::PromptLayer.GetRequestSearchSuggestionsField field,
            string? prefix = default,
            string? metadataKey = default,
            int? promptId = default,
            string? filterGroup = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Request Suggestions
        /// </summary>
        /// <param name="field"></param>
        /// <param name="prefix"></param>
        /// <param name="metadataKey"></param>
        /// <param name="promptId"></param>
        /// <param name="filterGroup"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.GetRequestSearchSuggestionsResponse>> GetRequestSearchSuggestionsAsResponseAsync(
            global::PromptLayer.GetRequestSearchSuggestionsField field,
            string? prefix = default,
            string? metadataKey = default,
            int? promptId = default,
            string? filterGroup = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}