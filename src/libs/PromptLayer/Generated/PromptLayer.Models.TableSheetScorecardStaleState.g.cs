
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScorecardStaleState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsStale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Reasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale_step_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? StaleStepIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stale_row_indices")]
        public global::System.Collections.Generic.IList<int>? StaleRowIndices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardStaleState" /> class.
        /// </summary>
        /// <param name="isStale"></param>
        /// <param name="reasons"></param>
        /// <param name="staleStepIds"></param>
        /// <param name="staleRowIndices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardStaleState(
            bool isStale,
            global::System.Collections.Generic.IList<string> reasons,
            global::System.Collections.Generic.IList<global::System.Guid>? staleStepIds,
            global::System.Collections.Generic.IList<int>? staleRowIndices)
        {
            this.IsStale = isStale;
            this.Reasons = reasons ?? throw new global::System.ArgumentNullException(nameof(reasons));
            this.StaleStepIds = staleStepIds;
            this.StaleRowIndices = staleRowIndices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardStaleState" /> class.
        /// </summary>
        public TableSheetScorecardStaleState()
        {
        }

    }
}