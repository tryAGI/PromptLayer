
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Per-dimension (model / prompt template / provider) latency series. Each percentile is a list of `[date, seconds]` pairs.
    /// </summary>
    public sealed partial class RequestAnalyticsDimensionLatency
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_latency")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? AverageLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_latency")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? P50Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90_latency")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? P90Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95_latency")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? P95Latency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsDimensionLatency" /> class.
        /// </summary>
        /// <param name="averageLatency"></param>
        /// <param name="p50Latency"></param>
        /// <param name="p90Latency"></param>
        /// <param name="p95Latency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsDimensionLatency(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? averageLatency,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? p50Latency,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? p90Latency,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? p95Latency)
        {
            this.AverageLatency = averageLatency;
            this.P50Latency = p50Latency;
            this.P90Latency = p90Latency;
            this.P95Latency = p95Latency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsDimensionLatency" /> class.
        /// </summary>
        public RequestAnalyticsDimensionLatency()
        {
        }

    }
}