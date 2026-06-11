
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// A computed ratio insight in the response.
    /// </summary>
    public sealed partial class DerivedRatioInsightResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.DerivedRatioInsightResultTypeJsonConverter))]
        public global::PromptLayer.DerivedRatioInsightResultType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeratorSeriesKey")]
        public string? NumeratorSeriesKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denominatorSeriesKey")]
        public string? DenominatorSeriesKey { get; set; }

        /// <summary>
        /// Ratio of numerator total to denominator total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedRatioInsightResult" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="label"></param>
        /// <param name="numeratorSeriesKey"></param>
        /// <param name="denominatorSeriesKey"></param>
        /// <param name="value">
        /// Ratio of numerator total to denominator total.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DerivedRatioInsightResult(
            global::PromptLayer.DerivedRatioInsightResultType? type,
            string? label,
            string? numeratorSeriesKey,
            string? denominatorSeriesKey,
            double? value)
        {
            this.Type = type;
            this.Label = label;
            this.NumeratorSeriesKey = numeratorSeriesKey;
            this.DenominatorSeriesKey = denominatorSeriesKey;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedRatioInsightResult" /> class.
        /// </summary>
        public DerivedRatioInsightResult()
        {
        }

    }
}