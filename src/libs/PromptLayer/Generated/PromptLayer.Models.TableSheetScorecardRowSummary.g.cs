
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScorecardRowSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_score")]
        public double? AggregateScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregate_verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScorecardRowSummaryAggregateVerdictJsonConverter))]
        public global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict? AggregateVerdict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drift_summary")]
        public object? DriftSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale_state")]
        public object? StaleState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_summary")]
        public string? ErrorSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardRowSummary" /> class.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="aggregateScore"></param>
        /// <param name="aggregateVerdict"></param>
        /// <param name="driftSummary"></param>
        /// <param name="staleState"></param>
        /// <param name="errorSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardRowSummary(
            int rowIndex,
            double? aggregateScore,
            global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict? aggregateVerdict,
            object? driftSummary,
            object? staleState,
            string? errorSummary)
        {
            this.RowIndex = rowIndex;
            this.AggregateScore = aggregateScore;
            this.AggregateVerdict = aggregateVerdict;
            this.DriftSummary = driftSummary;
            this.StaleState = staleState;
            this.ErrorSummary = errorSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardRowSummary" /> class.
        /// </summary>
        public TableSheetScorecardRowSummary()
        {
        }

    }
}