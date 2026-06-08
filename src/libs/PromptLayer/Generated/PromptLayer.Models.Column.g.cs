
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// A column within a Table sheet.
    /// </summary>
    public sealed partial class Column
    {
        /// <summary>
        /// Unique identifier of the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        public global::System.Guid? SheetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Display title of the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Column type. 'text' columns store free-text; 'prompt_template', 'llm', 'code', 'score', 'comparison', and 'composition' columns run automated computations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.ColumnTypeJsonConverter))]
        public global::PromptLayer.ColumnType? Type { get; set; }

        /// <summary>
        /// Type-specific configuration. Shape depends on the column type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Fractional position rank used for ordering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_rank")]
        public double? PositionRank { get; set; }

        /// <summary>
        /// Whether this column is designated as an output column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_output_column")]
        public bool? IsOutputColumn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the column.
        /// </param>
        /// <param name="sheetId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="title">
        /// Display title of the column.
        /// </param>
        /// <param name="type">
        /// Column type. 'text' columns store free-text; 'prompt_template', 'llm', 'code', 'score', 'comparison', and 'composition' columns run automated computations.
        /// </param>
        /// <param name="config">
        /// Type-specific configuration. Shape depends on the column type.
        /// </param>
        /// <param name="positionRank">
        /// Fractional position rank used for ordering.
        /// </param>
        /// <param name="isOutputColumn">
        /// Whether this column is designated as an output column.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Column(
            global::System.Guid? id,
            global::System.Guid? sheetId,
            int? workspaceId,
            string? title,
            global::PromptLayer.ColumnType? type,
            object? config,
            double? positionRank,
            bool? isOutputColumn)
        {
            this.Id = id;
            this.SheetId = sheetId;
            this.WorkspaceId = workspaceId;
            this.Title = title;
            this.Type = type;
            this.Config = config;
            this.PositionRank = positionRank;
            this.IsOutputColumn = isOutputColumn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        public Column()
        {
        }

    }
}