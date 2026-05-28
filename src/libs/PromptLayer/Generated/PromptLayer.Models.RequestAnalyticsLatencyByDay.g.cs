
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Per-bucket latency percentiles in seconds. Keys are bucket dates (e.g. `2025-03-15`); values are seconds.
    /// </summary>
    public sealed partial class RequestAnalyticsLatencyByDay
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_latency")]
        public global::System.Collections.Generic.Dictionary<string, double>? AverageLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_latency")]
        public global::System.Collections.Generic.Dictionary<string, double>? P50Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90_latency")]
        public global::System.Collections.Generic.Dictionary<string, double>? P90Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95_latency")]
        public global::System.Collections.Generic.Dictionary<string, double>? P95Latency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsLatencyByDay" /> class.
        /// </summary>
        /// <param name="averageLatency"></param>
        /// <param name="p50Latency"></param>
        /// <param name="p90Latency"></param>
        /// <param name="p95Latency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsLatencyByDay(
            global::System.Collections.Generic.Dictionary<string, double>? averageLatency,
            global::System.Collections.Generic.Dictionary<string, double>? p50Latency,
            global::System.Collections.Generic.Dictionary<string, double>? p90Latency,
            global::System.Collections.Generic.Dictionary<string, double>? p95Latency)
        {
            this.AverageLatency = averageLatency;
            this.P50Latency = p50Latency;
            this.P90Latency = p90Latency;
            this.P95Latency = p95Latency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsLatencyByDay" /> class.
        /// </summary>
        public RequestAnalyticsLatencyByDay()
        {
        }

    }
}