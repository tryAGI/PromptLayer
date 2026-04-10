
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditReportColumnResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// The updated column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_column")]
        public object? ReportColumn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditReportColumnResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="reportColumn">
        /// The updated column
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditReportColumnResponse(
            bool? success,
            object? reportColumn)
        {
            this.Success = success;
            this.ReportColumn = reportColumn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditReportColumnResponse" /> class.
        /// </summary>
        public EditReportColumnResponse()
        {
        }
    }
}