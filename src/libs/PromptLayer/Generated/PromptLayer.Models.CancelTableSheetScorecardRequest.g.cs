
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelTableSheetScorecardRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_indices")]
        public global::System.Collections.Generic.IList<int>? RowIndices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? StepIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTableSheetScorecardRequest" /> class.
        /// </summary>
        /// <param name="rowIndices"></param>
        /// <param name="stepIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelTableSheetScorecardRequest(
            global::System.Collections.Generic.IList<int>? rowIndices,
            global::System.Collections.Generic.IList<global::System.Guid>? stepIds)
        {
            this.RowIndices = rowIndices;
            this.StepIds = stepIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTableSheetScorecardRequest" /> class.
        /// </summary>
        public CancelTableSheetScorecardRequest()
        {
        }

    }
}