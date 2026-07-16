
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrateLegacyTableSheetScoreRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_legacy_score")]
        public bool? DeleteLegacyScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateLegacyTableSheetScoreRequest" /> class.
        /// </summary>
        /// <param name="deleteLegacyScore">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MigrateLegacyTableSheetScoreRequest(
            bool? deleteLegacyScore)
        {
            this.DeleteLegacyScore = deleteLegacyScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrateLegacyTableSheetScoreRequest" /> class.
        /// </summary>
        public MigrateLegacyTableSheetScoreRequest()
        {
        }

    }
}