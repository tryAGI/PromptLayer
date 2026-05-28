
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvaluationPipelineResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// ID of the created evaluation pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReportId { get; set; }

        /// <summary>
        /// Columns created on the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_columns")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ReportColumnSummary>? ReportColumns { get; set; }

        /// <summary>
        /// External ID mappings attached to the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.ExternalId> ExternalIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="reportId">
        /// ID of the created evaluation pipeline.
        /// </param>
        /// <param name="externalIds">
        /// External ID mappings attached to the pipeline.
        /// </param>
        /// <param name="reportColumns">
        /// Columns created on the pipeline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvaluationPipelineResponse(
            bool success,
            int reportId,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId> externalIds,
            global::System.Collections.Generic.IList<global::PromptLayer.ReportColumnSummary>? reportColumns)
        {
            this.Success = success;
            this.ReportId = reportId;
            this.ReportColumns = reportColumns;
            this.ExternalIds = externalIds ?? throw new global::System.ArgumentNullException(nameof(externalIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponse" /> class.
        /// </summary>
        public CreateEvaluationPipelineResponse()
        {
        }

    }
}