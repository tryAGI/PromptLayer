
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetScorecardGetResponseProgress
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scored_rows")]
        public int? ScoredRows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_rows")]
        public int? TotalRows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_score")]
        public double? PartialScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardGetResponseProgress" /> class.
        /// </summary>
        /// <param name="scoredRows"></param>
        /// <param name="totalRows"></param>
        /// <param name="partialScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardGetResponseProgress(
            int? scoredRows,
            int? totalRows,
            double? partialScore)
        {
            this.ScoredRows = scoredRows;
            this.TotalRows = totalRows;
            this.PartialScore = partialScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardGetResponseProgress" /> class.
        /// </summary>
        public TableSheetScorecardGetResponseProgress()
        {
        }

    }
}