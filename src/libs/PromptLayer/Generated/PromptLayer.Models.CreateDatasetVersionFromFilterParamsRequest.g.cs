
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
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
        /// List of input variables to extract as columns in the resulting dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables_to_parse")]
        public global::System.Collections.Generic.IList<string>? VariablesToParse { get; set; }

        /// <summary>
        /// Filter logs after this timestamp (ISO 8601). Example: 2026-04-22T17:00:00Z.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Filter logs before this timestamp (ISO 8601). Example: 2026-04-23T17:00:00Z.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Maximum number of request logs to include. Capped at 50,000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Free-text search query applied to the prompt input and LLM output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        /// Filter to a single request log by its numeric id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// When true, only include starred request logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred")]
        public bool? Starred { get; set; }

        /// <summary>
        /// When true, sample request logs in random order. Requires `limit` to be set.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by_random")]
        public bool? OrderByRandom { get; set; }

        /// <summary>
        /// Filter logs whose metadata matches ALL of the provided key/value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_and")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataAndItem>? MetadataAnd { get; set; }

        /// <summary>
        /// Filter logs whose metadata matches ANY of the provided key/value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_or")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataOrItem>? MetadataOr { get; set; }

        /// <summary>
        /// Filter logs that have ALL of the provided tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_and")]
        public global::System.Collections.Generic.IList<string>? TagsAnd { get; set; }

        /// <summary>
        /// Filter logs that have ANY of the provided tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_or")]
        public global::System.Collections.Generic.IList<string>? TagsOr { get; set; }

        /// <summary>
        /// Include logs associated with any of these prompt templates. Matches by template name, with optional version and/or release label narrowing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_templates_include")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem>? PromptTemplatesInclude { get; set; }

        /// <summary>
        /// Exclude logs associated with any of these prompt templates. Same shape as `prompt_templates_include`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_templates_exclude")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesExcludeItem>? PromptTemplatesExclude { get; set; }

        /// <summary>
        /// Filter logs by score comparisons. Each entry asserts that the named score satisfies `operator value`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScore>? Scores { get; set; }

        /// <summary>
        /// Filter logs by request status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestStatu>? Status { get; set; }

        /// <summary>
        /// Field to sort results by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortByJsonConverter))]
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy? SortBy { get; set; }

        /// <summary>
        /// Sort direction. Defaults to `desc` when `sort_by` is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateDatasetVersionFromFilterParamsRequestSortOrderJsonConverter))]
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Additional request-log fields to materialize as dataset columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_fields")]
        public global::System.Collections.Generic.IList<string>? IncludeFields { get; set; }

        /// <summary>
        /// When true, pivot metadata keys into dataset columns. Requires `metadata_and` or `metadata_or` to be set.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transpose_metadata_columns")]
        public bool? TransposeMetadataColumns { get; set; }

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
        /// <param name="variablesToParse">
        /// List of input variables to extract as columns in the resulting dataset.
        /// </param>
        /// <param name="startTime">
        /// Filter logs after this timestamp (ISO 8601). Example: 2026-04-22T17:00:00Z.
        /// </param>
        /// <param name="endTime">
        /// Filter logs before this timestamp (ISO 8601). Example: 2026-04-23T17:00:00Z.
        /// </param>
        /// <param name="limit">
        /// Maximum number of request logs to include. Capped at 50,000.
        /// </param>
        /// <param name="q">
        /// Free-text search query applied to the prompt input and LLM output.
        /// </param>
        /// <param name="id">
        /// Filter to a single request log by its numeric id.
        /// </param>
        /// <param name="starred">
        /// When true, only include starred request logs.
        /// </param>
        /// <param name="orderByRandom">
        /// When true, sample request logs in random order. Requires `limit` to be set.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadataAnd">
        /// Filter logs whose metadata matches ALL of the provided key/value pairs.
        /// </param>
        /// <param name="metadataOr">
        /// Filter logs whose metadata matches ANY of the provided key/value pairs.
        /// </param>
        /// <param name="tagsAnd">
        /// Filter logs that have ALL of the provided tags.
        /// </param>
        /// <param name="tagsOr">
        /// Filter logs that have ANY of the provided tags.
        /// </param>
        /// <param name="promptTemplatesInclude">
        /// Include logs associated with any of these prompt templates. Matches by template name, with optional version and/or release label narrowing.
        /// </param>
        /// <param name="promptTemplatesExclude">
        /// Exclude logs associated with any of these prompt templates. Same shape as `prompt_templates_include`.
        /// </param>
        /// <param name="scores">
        /// Filter logs by score comparisons. Each entry asserts that the named score satisfies `operator value`.
        /// </param>
        /// <param name="status">
        /// Filter logs by request status.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort results by.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to `desc` when `sort_by` is provided.
        /// </param>
        /// <param name="includeFields">
        /// Additional request-log fields to materialize as dataset columns.
        /// </param>
        /// <param name="transposeMetadataColumns">
        /// When true, pivot metadata keys into dataset columns. Requires `metadata_and` or `metadata_or` to be set.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFilterParamsRequest(
            int datasetGroupId,
            global::System.Collections.Generic.IList<string>? variablesToParse,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? limit,
            string? q,
            int? id,
            bool? starred,
            bool? orderByRandom,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataAndItem>? metadataAnd,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataOrItem>? metadataOr,
            global::System.Collections.Generic.IList<string>? tagsAnd,
            global::System.Collections.Generic.IList<string>? tagsOr,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem>? promptTemplatesInclude,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesExcludeItem>? promptTemplatesExclude,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScore>? scores,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestStatu>? status,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy? sortBy,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? sortOrder,
            global::System.Collections.Generic.IList<string>? includeFields,
            bool? transposeMetadataColumns)
        {
            this.DatasetGroupId = datasetGroupId;
            this.VariablesToParse = variablesToParse;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Limit = limit;
            this.Q = q;
            this.Id = id;
            this.Starred = starred;
            this.OrderByRandom = orderByRandom;
            this.MetadataAnd = metadataAnd;
            this.MetadataOr = metadataOr;
            this.TagsAnd = tagsAnd;
            this.TagsOr = tagsOr;
            this.PromptTemplatesInclude = promptTemplatesInclude;
            this.PromptTemplatesExclude = promptTemplatesExclude;
            this.Scores = scores;
            this.Status = status;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.IncludeFields = includeFields;
            this.TransposeMetadataColumns = transposeMetadataColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequest" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequest()
        {
        }
    }
}