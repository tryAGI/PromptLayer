
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MigrateLegacyTableSheetScoreResponseSkippedItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_type")]
        public string? ScoreType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateLegacyTableSheetScoreResponseSkippedItem" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="scoreType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MigrateLegacyTableSheetScoreResponseSkippedItem(
            string? reason,
            string? scoreType)
        {
            this.Reason = reason;
            this.ScoreType = scoreType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateLegacyTableSheetScoreResponseSkippedItem" /> class.
        /// </summary>
        public MigrateLegacyTableSheetScoreResponseSkippedItem()
        {
        }

    }
}