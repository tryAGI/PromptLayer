#nullable enable

namespace PromptLayer
{
    public partial interface IOtlpClient
    {
        /// <summary>
        /// Ingest Traces (OTLP)
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="closeAfter">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.OtlpExportTraceServiceResponse> IngestOtlpTracesAsync(
            global::PromptLayer.IngestOtlpTracesContentType contentType,

            global::PromptLayer.OtlpExportTraceServiceRequest request,
            global::PromptLayer.IngestOtlpTracesContentEncoding? contentEncoding = default,
            bool? closeAfter = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest Traces (OTLP)
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="closeAfter">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.OtlpExportTraceServiceResponse>> IngestOtlpTracesAsResponseAsync(
            global::PromptLayer.IngestOtlpTracesContentType contentType,

            global::PromptLayer.OtlpExportTraceServiceRequest request,
            global::PromptLayer.IngestOtlpTracesContentEncoding? contentEncoding = default,
            bool? closeAfter = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest Traces (OTLP)
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="closeAfter">
        /// Default Value: false
        /// </param>
        /// <param name="resourceSpans">
        /// An array of ResourceSpans. Each element describes spans from a single instrumented resource.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.OtlpExportTraceServiceResponse> IngestOtlpTracesAsync(
            global::PromptLayer.IngestOtlpTracesContentType contentType,
            global::PromptLayer.IngestOtlpTracesContentEncoding? contentEncoding = default,
            bool? closeAfter = default,
            global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>? resourceSpans = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}