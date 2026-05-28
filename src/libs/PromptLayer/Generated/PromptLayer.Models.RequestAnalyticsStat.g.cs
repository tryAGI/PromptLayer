
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// One time-series bucket.
    /// </summary>
    public sealed partial class RequestAnalyticsStat
    {
        /// <summary>
        /// ISO bucket key (e.g. `2025-03-15`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Human-readable bucket label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateLabel")]
        public string? DateLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public int? Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputTokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Average latency in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedTokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinkingTokens")]
        public int? ThinkingTokens { get; set; }

        /// <summary>
        /// Fraction of requests in the bucket that have a trace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceShare")]
        public double? TraceShare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCounts")]
        public global::System.Collections.Generic.Dictionary<string, int>? StatusCounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputShapeCounts")]
        public global::PromptLayer.RequestAnalyticsStatOutputShapeCounts? OutputShapeCounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgTurnCount")]
        public double? AvgTurnCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgToolCallCount")]
        public double? AvgToolCallCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallCountP95")]
        public double? ToolCallCountP95 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsStat" /> class.
        /// </summary>
        /// <param name="date">
        /// ISO bucket key (e.g. `2025-03-15`).
        /// </param>
        /// <param name="dateLabel">
        /// Human-readable bucket label.
        /// </param>
        /// <param name="requests"></param>
        /// <param name="tokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cost"></param>
        /// <param name="latency">
        /// Average latency in seconds.
        /// </param>
        /// <param name="cachedTokens"></param>
        /// <param name="thinkingTokens"></param>
        /// <param name="traceShare">
        /// Fraction of requests in the bucket that have a trace.
        /// </param>
        /// <param name="statusCounts"></param>
        /// <param name="outputShapeCounts"></param>
        /// <param name="avgTurnCount"></param>
        /// <param name="avgToolCallCount"></param>
        /// <param name="toolCallCountP95"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsStat(
            string? date,
            string? dateLabel,
            int? requests,
            int? tokens,
            int? inputTokens,
            int? outputTokens,
            double? cost,
            double? latency,
            int? cachedTokens,
            int? thinkingTokens,
            double? traceShare,
            global::System.Collections.Generic.Dictionary<string, int>? statusCounts,
            global::PromptLayer.RequestAnalyticsStatOutputShapeCounts? outputShapeCounts,
            double? avgTurnCount,
            double? avgToolCallCount,
            double? toolCallCountP95)
        {
            this.Date = date;
            this.DateLabel = dateLabel;
            this.Requests = requests;
            this.Tokens = tokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Cost = cost;
            this.Latency = latency;
            this.CachedTokens = cachedTokens;
            this.ThinkingTokens = thinkingTokens;
            this.TraceShare = traceShare;
            this.StatusCounts = statusCounts;
            this.OutputShapeCounts = outputShapeCounts;
            this.AvgTurnCount = avgTurnCount;
            this.AvgToolCallCount = avgToolCallCount;
            this.ToolCallCountP95 = toolCallCountP95;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsStat" /> class.
        /// </summary>
        public RequestAnalyticsStat()
        {
        }

    }
}