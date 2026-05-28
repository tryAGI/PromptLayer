
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestLogDetailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Provider-agnostic prompt blueprint that can be replayed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_blueprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object PromptBlueprint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public int? Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_start_time")]
        public global::System.DateTime? RequestStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_end_time")]
        public global::System.DateTime? RequestEndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        public double? LatencyMs { get; set; }

        /// <summary>
        /// Associated trace ID, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogDetailResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="promptBlueprint">
        /// Provider-agnostic prompt blueprint that can be replayed.
        /// </param>
        /// <param name="requestId"></param>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="tokens"></param>
        /// <param name="price"></param>
        /// <param name="requestStartTime"></param>
        /// <param name="requestEndTime"></param>
        /// <param name="latencyMs"></param>
        /// <param name="traceId">
        /// Associated trace ID, if available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestLogDetailResponse(
            bool success,
            object promptBlueprint,
            int requestId,
            string? provider,
            string? model,
            int? inputTokens,
            int? outputTokens,
            int? tokens,
            double? price,
            global::System.DateTime? requestStartTime,
            global::System.DateTime? requestEndTime,
            double? latencyMs,
            string? traceId)
        {
            this.Success = success;
            this.PromptBlueprint = promptBlueprint ?? throw new global::System.ArgumentNullException(nameof(promptBlueprint));
            this.RequestId = requestId;
            this.Provider = provider;
            this.Model = model;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Tokens = tokens;
            this.Price = price;
            this.RequestStartTime = requestStartTime;
            this.RequestEndTime = requestEndTime;
            this.LatencyMs = latencyMs;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogDetailResponse" /> class.
        /// </summary>
        public RequestLogDetailResponse()
        {
        }

    }
}