
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheetScoreHistoryResponseScoreHistory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Points { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returned_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReturnedPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TableSheetScoreHistoryResponseScoreHistoryResolutionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Range { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_sampled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSampled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreHistoryResponseScoreHistory" /> class.
        /// </summary>
        /// <param name="points"></param>
        /// <param name="totalPoints"></param>
        /// <param name="returnedPoints"></param>
        /// <param name="resolution"></param>
        /// <param name="range"></param>
        /// <param name="maxPoints"></param>
        /// <param name="isSampled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScoreHistoryResponseScoreHistory(
            global::System.Collections.Generic.IList<object> points,
            int totalPoints,
            int returnedPoints,
            global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution resolution,
            string range,
            int maxPoints,
            bool isSampled)
        {
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
            this.TotalPoints = totalPoints;
            this.ReturnedPoints = returnedPoints;
            this.Resolution = resolution;
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
            this.MaxPoints = maxPoints;
            this.IsSampled = isSampled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreHistoryResponseScoreHistory" /> class.
        /// </summary>
        public TableSheetScoreHistoryResponseScoreHistory()
        {
        }

    }
}