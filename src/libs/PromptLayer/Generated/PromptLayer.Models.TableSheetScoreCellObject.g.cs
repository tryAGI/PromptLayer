
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TableSheetScoreCellObject
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_metric")]
        public bool? PositiveMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreCellObject" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="positiveMetric"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSheetScoreCellObject(
            object? value,
            bool? positiveMetric)
        {
            this.Value = value;
            this.PositiveMetric = positiveMetric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheetScoreCellObject" /> class.
        /// </summary>
        public TableSheetScoreCellObject()
        {
        }

    }
}