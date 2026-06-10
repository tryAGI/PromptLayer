
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScoreConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScoreConfigurationScoreTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScoreConfigurationScoreType ScoreType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ScoreConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreConfiguration" /> class.
        /// </summary>
        /// <param name="scoreType"></param>
        /// <param name="scoreConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScoreConfiguration(
            global::PromptLayer.TableSheetScoreConfigurationScoreType scoreType,
            object scoreConfig)
        {
            this.ScoreType = scoreType;
            this.ScoreConfig = scoreConfig ?? throw new global::System.ArgumentNullException(nameof(scoreConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreConfiguration" /> class.
        /// </summary>
        public TableSheetScoreConfiguration()
        {
        }

    }
}