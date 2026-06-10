
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Import request history into an existing Table sheet. Provide either request_log_ids or filter_group.
    /// </summary>
    public sealed partial class CreateTableSheetRequestLogImportRequest
    {
        /// <summary>
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_group")]
        public global::PromptLayer.StructuredFilterGroup? FilterGroup { get; set; }

        /// <summary>
        /// Free-text request-log search query applied with filter_group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        /// Field to sort matching request logs before import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortByJsonConverter))]
        public global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy? SortBy { get; set; }

        /// <summary>
        /// Sort direction. Must be provided together with sort_by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestLogImportRequestSortOrderJsonConverter))]
        public global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Request-log query metadata key used by shared request-log query payloads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_cost_breakdown_key")]
        public string? MetadataCostBreakdownKey { get; set; }

        /// <summary>
        /// Optional client-provided operation ID. A UUID is generated when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        public string? OperationId { get; set; }

        /// <summary>
        /// Specific request log IDs to import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_log_ids")]
        public global::System.Collections.Generic.IList<int>? RequestLogIds { get; set; }

        /// <summary>
        /// Input variable names to parse from matching request logs.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables_to_parse")]
        public global::System.Collections.Generic.IList<string>? VariablesToParse { get; set; }

        /// <summary>
        /// Additional request log fields to include as columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_fields")]
        public global::System.Collections.Generic.IList<string>? IncludeFields { get; set; }

        /// <summary>
        /// Maximum number of matching request logs to import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetRequestLogImportRequest" /> class.
        /// </summary>
        /// <param name="filterGroup">
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </param>
        /// <param name="q">
        /// Free-text request-log search query applied with filter_group.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort matching request logs before import.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Must be provided together with sort_by.
        /// </param>
        /// <param name="metadataCostBreakdownKey">
        /// Request-log query metadata key used by shared request-log query payloads.
        /// </param>
        /// <param name="operationId">
        /// Optional client-provided operation ID. A UUID is generated when omitted.
        /// </param>
        /// <param name="requestLogIds">
        /// Specific request log IDs to import.
        /// </param>
        /// <param name="variablesToParse">
        /// Input variable names to parse from matching request logs.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="includeFields">
        /// Additional request log fields to include as columns.
        /// </param>
        /// <param name="limit">
        /// Maximum number of matching request logs to import.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetRequestLogImportRequest(
            global::PromptLayer.StructuredFilterGroup? filterGroup,
            string? q,
            global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy? sortBy,
            global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder? sortOrder,
            string? metadataCostBreakdownKey,
            string? operationId,
            global::System.Collections.Generic.IList<int>? requestLogIds,
            global::System.Collections.Generic.IList<string>? variablesToParse,
            global::System.Collections.Generic.IList<string>? includeFields,
            int? limit)
        {
            this.FilterGroup = filterGroup;
            this.Q = q;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.MetadataCostBreakdownKey = metadataCostBreakdownKey;
            this.OperationId = operationId;
            this.RequestLogIds = requestLogIds;
            this.VariablesToParse = variablesToParse;
            this.IncludeFields = includeFields;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetRequestLogImportRequest" /> class.
        /// </summary>
        public CreateTableSheetRequestLogImportRequest()
        {
        }

    }
}