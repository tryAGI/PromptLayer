
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScoreHistoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScoreHistoryResponseScoreHistory ScoreHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreHistoryResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="scoreHistory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScoreHistoryResponse(
            bool success,
            global::PromptLayer.TableSheetScoreHistoryResponseScoreHistory scoreHistory)
        {
            this.Success = success;
            this.ScoreHistory = scoreHistory ?? throw new global::System.ArgumentNullException(nameof(scoreHistory));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreHistoryResponse" /> class.
        /// </summary>
        public TableSheetScoreHistoryResponse()
        {
        }

    }
}