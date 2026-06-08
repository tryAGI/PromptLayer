
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTableSheetRowsResponse
    {
        /// <summary>
        /// Each item represents one row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ListTableSheetRowsResponseDataItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        public int? RowCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<global::PromptLayer.Column>? Columns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Sheet-level and per-column aggregates for price and latency metrics. Only present when `include_execution_metadata_aggregates=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_metadata_aggregates")]
        public global::PromptLayer.ExecutionMetadataAggregates? ExecutionMetadataAggregates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetRowsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Each item represents one row.
        /// </param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
        /// <param name="rowCount"></param>
        /// <param name="columns"></param>
        /// <param name="version"></param>
        /// <param name="executionMetadataAggregates">
        /// Sheet-level and per-column aggregates for price and latency metrics. Only present when `include_execution_metadata_aggregates=true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTableSheetRowsResponse(
            global::System.Collections.Generic.IList<global::PromptLayer.ListTableSheetRowsResponseDataItem>? data,
            string? nextCursor,
            bool? hasMore,
            int? rowCount,
            global::System.Collections.Generic.IList<global::PromptLayer.Column>? columns,
            int? version,
            global::PromptLayer.ExecutionMetadataAggregates? executionMetadataAggregates)
        {
            this.Data = data;
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.RowCount = rowCount;
            this.Columns = columns;
            this.Version = version;
            this.ExecutionMetadataAggregates = executionMetadataAggregates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetRowsResponse" /> class.
        /// </summary>
        public ListTableSheetRowsResponse()
        {
        }

    }
}