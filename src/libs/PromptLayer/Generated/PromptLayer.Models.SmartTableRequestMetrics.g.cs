
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Execution metrics for a prompt-template cell, derived from the underlying request log.
    /// </summary>
    public sealed partial class SmartTableRequestMetrics
    {
        /// <summary>
        /// Number of LLM requests made to produce this cell's value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        public int? RequestCount { get; set; }

        /// <summary>
        /// IDs of the request logs associated with this cell.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_ids")]
        public global::System.Collections.Generic.IList<int>? RequestIds { get; set; }

        /// <summary>
        /// Total end-to-end latency in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        public int? LatencyMs { get; set; }

        /// <summary>
        /// Total cost in USD for all requests that produced this cell.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Total number of input tokens across all requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Total number of output tokens across all requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Trace IDs linked to this cell (present when the cell was produced via an OpenTelemetry-traced workflow).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_ids")]
        public global::System.Collections.Generic.IList<string>? TraceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartTableRequestMetrics" /> class.
        /// </summary>
        /// <param name="requestCount">
        /// Number of LLM requests made to produce this cell's value.
        /// </param>
        /// <param name="requestIds">
        /// IDs of the request logs associated with this cell.
        /// </param>
        /// <param name="latencyMs">
        /// Total end-to-end latency in milliseconds.
        /// </param>
        /// <param name="price">
        /// Total cost in USD for all requests that produced this cell.
        /// </param>
        /// <param name="inputTokens">
        /// Total number of input tokens across all requests.
        /// </param>
        /// <param name="outputTokens">
        /// Total number of output tokens across all requests.
        /// </param>
        /// <param name="traceIds">
        /// Trace IDs linked to this cell (present when the cell was produced via an OpenTelemetry-traced workflow).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmartTableRequestMetrics(
            int? requestCount,
            global::System.Collections.Generic.IList<int>? requestIds,
            int? latencyMs,
            double? price,
            int? inputTokens,
            int? outputTokens,
            global::System.Collections.Generic.IList<string>? traceIds)
        {
            this.RequestCount = requestCount;
            this.RequestIds = requestIds;
            this.LatencyMs = latencyMs;
            this.Price = price;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TraceIds = traceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartTableRequestMetrics" /> class.
        /// </summary>
        public SmartTableRequestMetrics()
        {
        }

    }
}