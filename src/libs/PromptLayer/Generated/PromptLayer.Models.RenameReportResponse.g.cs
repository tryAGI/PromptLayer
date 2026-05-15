
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RenameReportResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.EvaluationPipelineSummary Report { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReportResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="report"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenameReportResponse(
            bool success,
            global::PromptLayer.EvaluationPipelineSummary report)
        {
            this.Success = success;
            this.Report = report ?? throw new global::System.ArgumentNullException(nameof(report));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReportResponse" /> class.
        /// </summary>
        public RenameReportResponse()
        {
        }

    }
}