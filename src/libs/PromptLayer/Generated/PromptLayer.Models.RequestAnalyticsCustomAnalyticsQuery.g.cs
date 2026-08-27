
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Request body for POST /api/public/v2/requests/analytics/custom-analytics. Inherits all filter fields from RequestLogQuery and adds `customCharts`.<br/>
    /// Example: {"filter_group":{"logic":"AND","filters":[{"field":"request_start_time","operator":"between","value":["2025-06-01T00:00:00Z","2025-06-08T00:00:00Z"]}]},"customCharts":[{"id":"cost_by_model","title":"Cost by Model","chartType":"bar","metric":"sum","metricField":"cost","groupByField":"engine"},{"id":"requests_over_time","title":"Requests Over Time","chartType":"line","metric":"count","timeSeries":true}]}
    /// </summary>
    public sealed partial class RequestAnalyticsCustomAnalyticsQuery
    {
        /// <summary>
        /// Nested filter group with AND/OR logic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_group")]
        public global::PromptLayer.StructuredFilterGroup? FilterGroup { get; set; }

        /// <summary>
        /// Free-text search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        /// Accepted for compatibility; does not affect aggregated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.RequestAnalyticsCustomAnalyticsQuerySortByJsonConverter))]
        public global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy? SortBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.RequestAnalyticsCustomAnalyticsQuerySortOrderJsonConverter))]
        public global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder? SortOrder { get; set; }

        /// <summary>
        /// One or more chart definitions to compute. Chart ids must be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customCharts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSpec> CustomCharts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsCustomAnalyticsQuery" /> class.
        /// </summary>
        /// <param name="customCharts">
        /// One or more chart definitions to compute. Chart ids must be unique.
        /// </param>
        /// <param name="filterGroup">
        /// Nested filter group with AND/OR logic.
        /// </param>
        /// <param name="q">
        /// Free-text search query.
        /// </param>
        /// <param name="sortBy">
        /// Accepted for compatibility; does not affect aggregated output.
        /// </param>
        /// <param name="sortOrder"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsCustomAnalyticsQuery(
            global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSpec> customCharts,
            global::PromptLayer.StructuredFilterGroup? filterGroup,
            string? q,
            global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy? sortBy,
            global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder? sortOrder)
        {
            this.FilterGroup = filterGroup;
            this.Q = q;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.CustomCharts = customCharts ?? throw new global::System.ArgumentNullException(nameof(customCharts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsCustomAnalyticsQuery" /> class.
        /// </summary>
        public RequestAnalyticsCustomAnalyticsQuery()
        {
        }

    }
}