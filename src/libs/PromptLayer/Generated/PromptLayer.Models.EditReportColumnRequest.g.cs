
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditReportColumnRequest
    {
        /// <summary>
        /// Parent evaluation pipeline ID. Must match the column's report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReportId { get; set; }

        /// <summary>
        /// Column type. DATASET is not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.EditReportColumnRequestColumnTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.EditReportColumnRequestColumnType ColumnType { get; set; }

        /// <summary>
        /// Replacement column configuration. Schema varies by column_type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// New column name. Must be unique within the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New 1-based position. Cannot overwrite dataset columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditReportColumnRequest" /> class.
        /// </summary>
        /// <param name="reportId">
        /// Parent evaluation pipeline ID. Must match the column's report.
        /// </param>
        /// <param name="columnType">
        /// Column type. DATASET is not allowed.
        /// </param>
        /// <param name="configuration">
        /// Replacement column configuration. Schema varies by column_type.
        /// </param>
        /// <param name="name">
        /// New column name. Must be unique within the pipeline.
        /// </param>
        /// <param name="position">
        /// New 1-based position. Cannot overwrite dataset columns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditReportColumnRequest(
            int reportId,
            global::PromptLayer.EditReportColumnRequestColumnType columnType,
            object? configuration,
            string? name,
            int? position)
        {
            this.ReportId = reportId;
            this.ColumnType = columnType;
            this.Configuration = configuration;
            this.Name = name;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditReportColumnRequest" /> class.
        /// </summary>
        public EditReportColumnRequest()
        {
        }

    }
}