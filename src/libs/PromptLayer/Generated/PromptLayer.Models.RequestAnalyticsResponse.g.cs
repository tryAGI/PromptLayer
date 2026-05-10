
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Aggregated analytics across the matching request logs. Bucket size is selected automatically based on the filter time range (seconds → minutes → hours → days).
    /// </summary>
    public sealed partial class RequestAnalyticsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Bucket-interval metadata describing how the time-series was bucketed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartInterval")]
        public global::PromptLayer.RequestAnalyticsResponseChartInterval? ChartInterval { get; set; }

        /// <summary>
        /// Overall average latency across all matching requests, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageLatency")]
        public double? AverageLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRequests")]
        public int? TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCachedTokens")]
        public int? TotalCachedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalThinkingTokens")]
        public int? TotalThinkingTokens { get; set; }

        /// <summary>
        /// `totalCachedTokens / total_input_tokens`, or null when there are no input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheTokenRatio")]
        public double? CacheTokenRatio { get; set; }

        /// <summary>
        /// Per-bucket time-series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsStat>? Stats { get; set; }

        /// <summary>
        /// List of `[modelName, requestCount]` pairs ordered by usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mostUsedModels")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? MostUsedModels { get; set; }

        /// <summary>
        /// Map of model name → list of `[date, requestCount]` pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelRequestsByDay")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>>? ModelRequestsByDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mostUsedPromptTemplates")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMostUsedPromptTemplate>? MostUsedPromptTemplates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTemplateRequestsByDay")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>>? PromptTemplateRequestsByDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerRequestsByDay")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>>? ProviderRequestsByDay { get; set; }

        /// <summary>
        /// Per-bucket latency percentiles in seconds. Keys are bucket dates (e.g. `2025-03-15`); values are seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public global::PromptLayer.RequestAnalyticsLatencyByDay? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyByModelByDay")]
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.RequestAnalyticsDimensionLatency>? LatencyByModelByDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyByPromptTemplateByDay")]
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.RequestAnalyticsDimensionLatency>? LatencyByPromptTemplateByDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyByProviderByDay")]
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.RequestAnalyticsDimensionLatency>? LatencyByProviderByDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorTypes")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseErrorType>? ErrorTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerBreakdown")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsBreakdownEntry>? ProviderBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptBreakdown")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsBreakdownEntry>? PromptBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagsBreakdown")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsBreakdownEntry>? TagsBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadataKeysTop")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMetadataKeysTopItem>? MetadataKeysTop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputKeysTop")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseOutputKeysTopItem>? OutputKeysTop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolsLatency")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsToolLatency>? ToolsLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolsUsageBars")]
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseToolsUsageBar>? ToolsUsageBars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="chartInterval">
        /// Bucket-interval metadata describing how the time-series was bucketed.
        /// </param>
        /// <param name="averageLatency">
        /// Overall average latency across all matching requests, in seconds.
        /// </param>
        /// <param name="totalCost"></param>
        /// <param name="totalTokens"></param>
        /// <param name="totalRequests"></param>
        /// <param name="totalCachedTokens"></param>
        /// <param name="totalThinkingTokens"></param>
        /// <param name="cacheTokenRatio">
        /// `totalCachedTokens / total_input_tokens`, or null when there are no input tokens.
        /// </param>
        /// <param name="stats">
        /// Per-bucket time-series.
        /// </param>
        /// <param name="mostUsedModels">
        /// List of `[modelName, requestCount]` pairs ordered by usage.
        /// </param>
        /// <param name="modelRequestsByDay">
        /// Map of model name → list of `[date, requestCount]` pairs.
        /// </param>
        /// <param name="mostUsedPromptTemplates"></param>
        /// <param name="promptTemplateRequestsByDay"></param>
        /// <param name="providerRequestsByDay"></param>
        /// <param name="latency">
        /// Per-bucket latency percentiles in seconds. Keys are bucket dates (e.g. `2025-03-15`); values are seconds.
        /// </param>
        /// <param name="latencyByModelByDay"></param>
        /// <param name="latencyByPromptTemplateByDay"></param>
        /// <param name="latencyByProviderByDay"></param>
        /// <param name="errorTypes"></param>
        /// <param name="providerBreakdown"></param>
        /// <param name="promptBreakdown"></param>
        /// <param name="tagsBreakdown"></param>
        /// <param name="metadataKeysTop"></param>
        /// <param name="outputKeysTop"></param>
        /// <param name="toolsLatency"></param>
        /// <param name="toolsUsageBars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsResponse(
            bool success,
            global::PromptLayer.RequestAnalyticsResponseChartInterval? chartInterval,
            double? averageLatency,
            double? totalCost,
            int? totalTokens,
            int? totalRequests,
            int? totalCachedTokens,
            int? totalThinkingTokens,
            double? cacheTokenRatio,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsStat>? stats,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? mostUsedModels,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>>? modelRequestsByDay,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMostUsedPromptTemplate>? mostUsedPromptTemplates,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>>? promptTemplateRequestsByDay,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>>? providerRequestsByDay,
            global::PromptLayer.RequestAnalyticsLatencyByDay? latency,
            global::System.Collections.Generic.Dictionary<string, global::PromptLayer.RequestAnalyticsDimensionLatency>? latencyByModelByDay,
            global::System.Collections.Generic.Dictionary<string, global::PromptLayer.RequestAnalyticsDimensionLatency>? latencyByPromptTemplateByDay,
            global::System.Collections.Generic.Dictionary<string, global::PromptLayer.RequestAnalyticsDimensionLatency>? latencyByProviderByDay,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseErrorType>? errorTypes,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsBreakdownEntry>? providerBreakdown,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsBreakdownEntry>? promptBreakdown,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsBreakdownEntry>? tagsBreakdown,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMetadataKeysTopItem>? metadataKeysTop,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseOutputKeysTopItem>? outputKeysTop,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsToolLatency>? toolsLatency,
            global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseToolsUsageBar>? toolsUsageBars)
        {
            this.Success = success;
            this.ChartInterval = chartInterval;
            this.AverageLatency = averageLatency;
            this.TotalCost = totalCost;
            this.TotalTokens = totalTokens;
            this.TotalRequests = totalRequests;
            this.TotalCachedTokens = totalCachedTokens;
            this.TotalThinkingTokens = totalThinkingTokens;
            this.CacheTokenRatio = cacheTokenRatio;
            this.Stats = stats;
            this.MostUsedModels = mostUsedModels;
            this.ModelRequestsByDay = modelRequestsByDay;
            this.MostUsedPromptTemplates = mostUsedPromptTemplates;
            this.PromptTemplateRequestsByDay = promptTemplateRequestsByDay;
            this.ProviderRequestsByDay = providerRequestsByDay;
            this.Latency = latency;
            this.LatencyByModelByDay = latencyByModelByDay;
            this.LatencyByPromptTemplateByDay = latencyByPromptTemplateByDay;
            this.LatencyByProviderByDay = latencyByProviderByDay;
            this.ErrorTypes = errorTypes;
            this.ProviderBreakdown = providerBreakdown;
            this.PromptBreakdown = promptBreakdown;
            this.TagsBreakdown = tagsBreakdown;
            this.MetadataKeysTop = metadataKeysTop;
            this.OutputKeysTop = outputKeysTop;
            this.ToolsLatency = toolsLatency;
            this.ToolsUsageBars = toolsUsageBars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponse" /> class.
        /// </summary>
        public RequestAnalyticsResponse()
        {
        }

    }
}