
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvaluationPipelineRequest
    {
        /// <summary>
        /// ID of the dataset group to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// Name for the pipeline. Auto-generated if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Folder ID for organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Specific dataset version. Uses latest published version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_version_number")]
        public int? DatasetVersionNumber { get; set; }

        /// <summary>
        /// Evaluation columns to add to the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<global::PromptLayer.EvaluationColumnDefinition>? Columns { get; set; }

        /// <summary>
        /// Optional custom scoring logic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_configuration")]
        public global::PromptLayer.ScoreConfiguration? ScoreConfiguration { get; set; }

        /// <summary>
        /// External ID mappings to attach to the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? ExternalIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group to use.
        /// </param>
        /// <param name="name">
        /// Name for the pipeline. Auto-generated if omitted.
        /// </param>
        /// <param name="folderId">
        /// Folder ID for organization.
        /// </param>
        /// <param name="datasetVersionNumber">
        /// Specific dataset version. Uses latest published version if omitted.
        /// </param>
        /// <param name="columns">
        /// Evaluation columns to add to the pipeline.
        /// </param>
        /// <param name="scoreConfiguration">
        /// Optional custom scoring logic.
        /// </param>
        /// <param name="externalIds">
        /// External ID mappings to attach to the pipeline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvaluationPipelineRequest(
            int datasetGroupId,
            string? name,
            int? folderId,
            int? datasetVersionNumber,
            global::System.Collections.Generic.IList<global::PromptLayer.EvaluationColumnDefinition>? columns,
            global::PromptLayer.ScoreConfiguration? scoreConfiguration,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds)
        {
            this.DatasetGroupId = datasetGroupId;
            this.Name = name;
            this.FolderId = folderId;
            this.DatasetVersionNumber = datasetVersionNumber;
            this.Columns = columns;
            this.ScoreConfiguration = scoreConfiguration;
            this.ExternalIds = externalIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineRequest" /> class.
        /// </summary>
        public CreateEvaluationPipelineRequest()
        {
        }

    }
}