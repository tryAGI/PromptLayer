
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Canonical request-log query payload — the filter / search / sort fields shared by `POST /api/public/v2/requests/search` (which also accepts pagination + `include_prompt_name`) and `POST /api/public/v2/requests/analytics`.<br/>
    /// Example: {"filter_group":{"logic":"AND","filters":[{"field":"engine","operator":"is","value":"gpt-4o"}]},"sort_by":"request_start_time","sort_order":"desc"}
    /// </summary>
    public sealed partial class RequestLogQuery
    {
        /// <summary>
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_group")]
        public global::PromptLayer.StructuredFilterGroup? FilterGroup { get; set; }

        /// <summary>
        /// Free-text search query. Searches across the prompt input and LLM output text using fuzzy prefix matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        /// Field to sort results by. Does not affect aggregated output for `/requests/analytics`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortByJsonConverter))]
        public global::PromptLayer.RequestLogQuerySortBy? SortBy { get; set; }

        /// <summary>
        /// Sort direction. Must be provided together with sort_by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.RequestLogQuerySortOrderJsonConverter))]
        public global::PromptLayer.RequestLogQuerySortOrder? SortOrder { get; set; }

        /// <summary>
        /// When provided, the analytics response includes a `metadataValueBreakdown` array with cost and request counts for each value of this metadata key. Omit or pass null to get an aggregate breakdown across the top metadata keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_cost_breakdown_key")]
        public string? MetadataCostBreakdownKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogQuery" /> class.
        /// </summary>
        /// <param name="filterGroup">
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </param>
        /// <param name="q">
        /// Free-text search query. Searches across the prompt input and LLM output text using fuzzy prefix matching.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort results by. Does not affect aggregated output for `/requests/analytics`.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Must be provided together with sort_by.
        /// </param>
        /// <param name="metadataCostBreakdownKey">
        /// When provided, the analytics response includes a `metadataValueBreakdown` array with cost and request counts for each value of this metadata key. Omit or pass null to get an aggregate breakdown across the top metadata keys.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestLogQuery(
            global::PromptLayer.StructuredFilterGroup? filterGroup,
            string? q,
            global::PromptLayer.RequestLogQuerySortBy? sortBy,
            global::PromptLayer.RequestLogQuerySortOrder? sortOrder,
            string? metadataCostBreakdownKey)
        {
            this.FilterGroup = filterGroup;
            this.Q = q;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.MetadataCostBreakdownKey = metadataCostBreakdownKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogQuery" /> class.
        /// </summary>
        public RequestLogQuery()
        {
        }

    }
}