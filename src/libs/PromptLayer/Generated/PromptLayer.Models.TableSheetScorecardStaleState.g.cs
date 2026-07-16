
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardStaleState" /> class.
        /// </summary>
        /// <param name="isStale"></param>
        /// <param name="reasons"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScorecardStaleState(
            bool isStale,
            global::System.Collections.Generic.IList<string> reasons)
        {
            this.IsStale = isStale;
            this.Reasons = reasons ?? throw new global::System.ArgumentNullException(nameof(reasons));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScorecardStaleState" /> class.
        /// </summary>
        public TableSheetScorecardStaleState()
        {
        }

    }
}