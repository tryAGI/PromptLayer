
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetReportResponseReportColumn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_id")]
        public int? ReportId { get; set; }

        /// <summary>
        /// Type of evaluation column (e.g. LLM_ASSERTION, PROMPT_TEMPLATE, COMPARE)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_type")]
        public string? ColumnType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Zero-based column order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_part_of_score")]
        public bool? IsPartOfScore { get; set; }

        /// <summary>
        /// Column-type-specific configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// Computed score for this column, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseReportColumn" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reportId"></param>
        /// <param name="columnType">
        /// Type of evaluation column (e.g. LLM_ASSERTION, PROMPT_TEMPLATE, COMPARE)
        /// </param>
        /// <param name="name"></param>
        /// <param name="position">
        /// Zero-based column order
        /// </param>
        /// <param name="isPartOfScore"></param>
        /// <param name="configuration">
        /// Column-type-specific configuration
        /// </param>
        /// <param name="score">
        /// Computed score for this column, if available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetReportResponseReportColumn(
            int? id,
            int? reportId,
            string? columnType,
            string? name,
            int? position,
            bool? isPartOfScore,
            object? configuration,
            double? score)
        {
            this.Id = id;
            this.ReportId = reportId;
            this.ColumnType = columnType;
            this.Name = name;
            this.Position = position;
            this.IsPartOfScore = isPartOfScore;
            this.Configuration = configuration;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseReportColumn" /> class.
        /// </summary>
        public GetReportResponseReportColumn()
        {
        }

    }
}