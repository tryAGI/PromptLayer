
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Send either `request_log_ids` (static snapshot) or `filter_group` + `q`/`sort_by`/`sort_order` (dynamic structured query). When both are present, `request_log_ids` wins.
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsRequest
    {
        /// <summary>
        /// ID of the dataset group where the new version will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// Explicit list of request_log ids to include. Capped at 50,000. All ids must belong to the same workspace as the dataset group; cross-workspace ids return 400. Datasets created in this mode are static snapshots — `filter_params` is left null and the dataset cannot be refreshed via run-report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_log_ids")]
        public global::System.Collections.Generic.IList<int>? RequestLogIds { get; set; }

        /// <summary>
        /// Structured filter group, identical in shape to the one accepted by `POST /api/public/v2/requests/search`. The full payload is persisted to the dataset so it can be replayed on refresh.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_group")]
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestFilterGroup? FilterGroup { get; set; }

        /// <summary>
        /// Free-text search query applied alongside `filter_group`. Mirrors `q` from the unified request-log search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        /// Field to sort the structured query by. Same allowed values as `POST /api/public/v2/requests/search` (e.g. `request_start_time`, `input_tokens`, `output_tokens`, `cost`, `latency_ms`, `status`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public string? SortBy { get; set; }

        /// <summary>
        /// Sort direction. Defaults to `desc` when `sort_by` is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderJsonConverter))]
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// List of input variables to extract as columns in the resulting dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables_to_parse")]
        public global::System.Collections.Generic.IList<string>? VariablesToParse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group where the new version will be created.
        /// </param>
        /// <param name="requestLogIds">
        /// Explicit list of request_log ids to include. Capped at 50,000. All ids must belong to the same workspace as the dataset group; cross-workspace ids return 400. Datasets created in this mode are static snapshots — `filter_params` is left null and the dataset cannot be refreshed via run-report.
        /// </param>
        /// <param name="filterGroup">
        /// Structured filter group, identical in shape to the one accepted by `POST /api/public/v2/requests/search`. The full payload is persisted to the dataset so it can be replayed on refresh.
        /// </param>
        /// <param name="q">
        /// Free-text search query applied alongside `filter_group`. Mirrors `q` from the unified request-log search.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort the structured query by. Same allowed values as `POST /api/public/v2/requests/search` (e.g. `request_start_time`, `input_tokens`, `output_tokens`, `cost`, `latency_ms`, `status`).
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to `desc` when `sort_by` is provided.
        /// </param>
        /// <param name="variablesToParse">
        /// List of input variables to extract as columns in the resulting dataset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFilterParamsRequest(
            int datasetGroupId,
            global::System.Collections.Generic.IList<int>? requestLogIds,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestFilterGroup? filterGroup,
            string? q,
            string? sortBy,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? sortOrder,
            global::System.Collections.Generic.IList<string>? variablesToParse)
        {
            this.DatasetGroupId = datasetGroupId;
            this.RequestLogIds = requestLogIds;
            this.FilterGroup = filterGroup;
            this.Q = q;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.VariablesToParse = variablesToParse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequest" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequest()
        {
        }
    }
}