
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigureTableSheetScorecardResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScorecard Scorecard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTableSheetScorecardResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="scorecard"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureTableSheetScorecardResponse(
            bool success,
            global::PromptLayer.TableSheetScorecard scorecard,
            int version)
        {
            this.Success = success;
            this.Scorecard = scorecard ?? throw new global::System.ArgumentNullException(nameof(scorecard));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureTableSheetScorecardResponse" /> class.
        /// </summary>
        public ConfigureTableSheetScorecardResponse()
        {
        }

    }
}