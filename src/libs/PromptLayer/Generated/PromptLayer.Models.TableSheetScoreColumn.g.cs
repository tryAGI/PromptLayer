
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetScoreColumn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ColumnId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IncludedCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExcludedCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_scoring_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScoreColumnResolvedScoringTypeJsonConverter))]
        public global::PromptLayer.TableSheetScoreColumnResolvedScoringType? ResolvedScoringType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreColumn" /> class.
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="title"></param>
        /// <param name="includedCount"></param>
        /// <param name="excludedCount"></param>
        /// <param name="score"></param>
        /// <param name="resolvedScoringType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScoreColumn(
            global::System.Guid columnId,
            string title,
            int includedCount,
            int excludedCount,
            double? score,
            global::PromptLayer.TableSheetScoreColumnResolvedScoringType? resolvedScoringType)
        {
            this.ColumnId = columnId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Score = score;
            this.IncludedCount = includedCount;
            this.ExcludedCount = excludedCount;
            this.ResolvedScoringType = resolvedScoringType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreColumn" /> class.
        /// </summary>
        public TableSheetScoreColumn()
        {
        }

    }
}