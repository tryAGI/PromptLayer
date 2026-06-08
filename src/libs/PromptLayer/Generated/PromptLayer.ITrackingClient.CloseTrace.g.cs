#nullable enable

namespace PromptLayer
{
    public partial interface ITrackingClient
    {
        /// <summary>
        /// Close Trace<br/>
        /// Marks a trace as closed, preventing any further span ingestion for that trace. Once closed, subsequent calls to `/spans-bulk` or `/v1/traces` that include spans for this trace will have those spans rejected.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CloseTraceResponse> CloseTraceAsync(
            string traceId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Close Trace<br/>
        /// Marks a trace as closed, preventing any further span ingestion for that trace. Once closed, subsequent calls to `/spans-bulk` or `/v1/traces` that include spans for this trace will have those spans rejected.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CloseTraceResponse>> CloseTraceAsResponseAsync(
            string traceId,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}