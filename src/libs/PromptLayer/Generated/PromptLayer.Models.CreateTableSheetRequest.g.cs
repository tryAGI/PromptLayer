
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetRequest
    {
        /// <summary>
        /// Sheet title. Defaults to the source file name or 'Request Logs'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Display position within the table (0-based). Defaults to appending at the end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Optional idempotency key for the import operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        public string? OperationId { get; set; }

        /// <summary>
        /// Data source for the sheet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.OneOf<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetRequest" /> class.
        /// </summary>
        /// <param name="source">
        /// Data source for the sheet.
        /// </param>
        /// <param name="title">
        /// Sheet title. Defaults to the source file name or 'Request Logs'.
        /// </param>
        /// <param name="index">
        /// Display position within the table (0-based). Defaults to appending at the end.
        /// </param>
        /// <param name="operationId">
        /// Optional idempotency key for the import operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetRequest(
            global::PromptLayer.OneOf<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource> source,
            string? title,
            int? index,
            string? operationId)
        {
            this.Title = title;
            this.Index = index;
            this.OperationId = operationId;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetRequest" /> class.
        /// </summary>
        public CreateTableSheetRequest()
        {
        }

    }
}