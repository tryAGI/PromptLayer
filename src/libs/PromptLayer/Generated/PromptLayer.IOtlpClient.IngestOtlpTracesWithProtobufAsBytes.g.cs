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
        global::System.Threading.Tasks.Task<byte[]> IngestOtlpTracesWithProtobufAsBytesAsync(
            global::PromptLayer.IngestOtlpTracesContentType contentType,

            byte[] request,
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> IngestOtlpTracesWithProtobufAsBytesAsStreamAsync(
            global::PromptLayer.IngestOtlpTracesContentType contentType,

            byte[] request,
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
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<byte[]>> IngestOtlpTracesWithProtobufAsBytesAsResponseAsync(
            global::PromptLayer.IngestOtlpTracesContentType contentType,

            byte[] request,
            global::PromptLayer.IngestOtlpTracesContentEncoding? contentEncoding = default,
            bool? closeAfter = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}