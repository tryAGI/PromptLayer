
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsRequest
    {
        /// <summary>
        /// Dataset group that will receive the generated dataset version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// Explicit request log IDs to snapshot. When provided, this mode takes precedence over filter_group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_log_ids")]
        public global::System.Collections.Generic.IList<int>? RequestLogIds { get; set; }

        /// <summary>
        /// Structured request-log filters used to populate the dataset asynchronously.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_group")]
        public global::PromptLayer.StructuredFilterGroup? FilterGroup { get; set; }

        /// <summary>
        /// Free-text request-log search query applied with filter_group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByJsonConverter))]
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy? SortBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderJsonConverter))]
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Request fields or variables to parse into dataset columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables_to_parse")]
        public global::System.Collections.Generic.IList<string>? VariablesToParse { get; set; }

        /// <summary>
        /// Maximum number of request logs to include. When set, only the first N matching rows (in the current sort order) are added to the dataset version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// Dataset group that will receive the generated dataset version.
        /// </param>
        /// <param name="requestLogIds">
        /// Explicit request log IDs to snapshot. When provided, this mode takes precedence over filter_group.
        /// </param>
        /// <param name="filterGroup">
        /// Structured request-log filters used to populate the dataset asynchronously.
        /// </param>
        /// <param name="q">
        /// Free-text request-log search query applied with filter_group.
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="sortOrder"></param>
        /// <param name="variablesToParse">
        /// Request fields or variables to parse into dataset columns.
        /// </param>
        /// <param name="limit">
        /// Maximum number of request logs to include. When set, only the first N matching rows (in the current sort order) are added to the dataset version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFilterParamsRequest(
            int datasetGroupId,
            global::System.Collections.Generic.IList<int>? requestLogIds,
            global::PromptLayer.StructuredFilterGroup? filterGroup,
            string? q,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy? sortBy,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? sortOrder,
            global::System.Collections.Generic.IList<string>? variablesToParse,
            int? limit)
        {
            this.DatasetGroupId = datasetGroupId;
            this.RequestLogIds = requestLogIds;
            this.FilterGroup = filterGroup;
            this.Q = q;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.VariablesToParse = variablesToParse;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequest" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequest()
        {
        }

    }
}