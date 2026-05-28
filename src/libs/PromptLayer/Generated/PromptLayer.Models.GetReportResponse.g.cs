
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetReportResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The report data with all fields
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report")]
        public global::PromptLayer.GetReportResponseReport? Report { get; set; }

        /// <summary>
        /// Overall status of the report execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.GetReportResponseStatusJsonConverter))]
        public global::PromptLayer.GetReportResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::PromptLayer.GetReportResponseStats? Stats { get; set; }

        /// <summary>
        /// Ordered list of column configurations for this report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_columns")]
        public global::System.Collections.Generic.IList<global::PromptLayer.GetReportResponseReportColumn>? ReportColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="report">
        /// The report data with all fields
        /// </param>
        /// <param name="status">
        /// Overall status of the report execution
        /// </param>
        /// <param name="stats"></param>
        /// <param name="reportColumns">
        /// Ordered list of column configurations for this report.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetReportResponse(
            bool? success,
            string? message,
            global::PromptLayer.GetReportResponseReport? report,
            global::PromptLayer.GetReportResponseStatus? status,
            global::PromptLayer.GetReportResponseStats? stats,
            global::System.Collections.Generic.IList<global::PromptLayer.GetReportResponseReportColumn>? reportColumns)
        {
            this.Success = success;
            this.Message = message;
            this.Report = report;
            this.Status = status;
            this.Stats = stats;
            this.ReportColumns = reportColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponse" /> class.
        /// </summary>
        public GetReportResponse()
        {
        }

    }
}