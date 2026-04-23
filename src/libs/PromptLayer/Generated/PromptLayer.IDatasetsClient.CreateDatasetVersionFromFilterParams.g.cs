#nullable enable

namespace PromptLayer
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset Version from Filter Params
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(

            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Version from Filter Params
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse> CreateDatasetVersionFromFilterParamsAsync(
            int datasetGroupId,
            global::System.Collections.Generic.IList<string>? variablesToParse = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? limit = default,
            string? q = default,
            int? id = default,
            bool? starred = default,
            bool? orderByRandom = default,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataAndItem>? metadataAnd = default,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataOrItem>? metadataOr = default,
            global::System.Collections.Generic.IList<string>? tagsAnd = default,
            global::System.Collections.Generic.IList<string>? tagsOr = default,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem>? promptTemplatesInclude = default,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesExcludeItem>? promptTemplatesExclude = default,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScore>? scores = default,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestStatu>? status = default,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy? sortBy = default,
            global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? sortOrder = default,
            global::System.Collections.Generic.IList<string>? includeFields = default,
            bool? transposeMetadataColumns = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}