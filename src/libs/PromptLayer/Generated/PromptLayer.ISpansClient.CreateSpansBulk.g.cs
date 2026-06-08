#nullable enable

namespace PromptLayer
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Create Spans Bulk
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateSpansBulkResponse> CreateSpansBulkAsync(

            global::PromptLayer.CreateSpansBulk request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Spans Bulk
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateSpansBulkResponse>> CreateSpansBulkAsResponseAsync(

            global::PromptLayer.CreateSpansBulk request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Spans Bulk
        /// </summary>
        /// <param name="spans"></param>
        /// <param name="closeAfter">
        /// When true, all trace IDs in this batch are marked as closed after the spans are persisted. Subsequent span writes for those traces will be rejected with a trace_closed rejection reason. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateSpansBulkResponse> CreateSpansBulkAsync(
            global::System.Collections.Generic.IList<global::PromptLayer.Span> spans,
            bool? closeAfter = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}