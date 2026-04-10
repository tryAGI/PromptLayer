
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
        public bool? Success { get; set; }

        /// <summary>
        /// The updated report
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report")]
        public object? Report { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReportResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="report">
        /// The updated report
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenameReportResponse(
            bool? success,
            object? report)
        {
            this.Success = success;
            this.Report = report;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReportResponse" /> class.
        /// </summary>
        public RenameReportResponse()
        {
        }
    }
}