
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Per-tool latency stats.
    /// </summary>
    public sealed partial class RequestAnalyticsToolLatency
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgLatencySeconds")]
        public double? AvgLatencySeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minLatencySeconds")]
        public double? MinLatencySeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxLatencySeconds")]
        public double? MaxLatencySeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsToolLatency" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="requests"></param>
        /// <param name="avgLatencySeconds"></param>
        /// <param name="minLatencySeconds"></param>
        /// <param name="maxLatencySeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsToolLatency(
            string? toolName,
            int? requests,
            double? avgLatencySeconds,
            double? minLatencySeconds,
            double? maxLatencySeconds)
        {
            this.ToolName = toolName;
            this.Requests = requests;
            this.AvgLatencySeconds = avgLatencySeconds;
            this.MinLatencySeconds = minLatencySeconds;
            this.MaxLatencySeconds = maxLatencySeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsToolLatency" /> class.
        /// </summary>
        public RequestAnalyticsToolLatency()
        {
        }
    }
}