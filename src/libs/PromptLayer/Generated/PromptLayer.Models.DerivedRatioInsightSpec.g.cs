
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// A display-only derived insight computed as a ratio of two series totals.
    /// </summary>
    public sealed partial class DerivedRatioInsightSpec
    {
        /// <summary>
        /// Default Value: ratio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.DerivedRatioInsightSpecTypeJsonConverter))]
        public global::PromptLayer.DerivedRatioInsightSpecType? Type { get; set; }

        /// <summary>
        /// Label shown for this insight (max 200 chars).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Key of the numerator series (must match a series key in the chart).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeratorSeriesKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NumeratorSeriesKey { get; set; }

        /// <summary>
        /// Key of the denominator series (must match a series key in the chart).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denominatorSeriesKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DenominatorSeriesKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedRatioInsightSpec" /> class.
        /// </summary>
        /// <param name="label">
        /// Label shown for this insight (max 200 chars).
        /// </param>
        /// <param name="numeratorSeriesKey">
        /// Key of the numerator series (must match a series key in the chart).
        /// </param>
        /// <param name="denominatorSeriesKey">
        /// Key of the denominator series (must match a series key in the chart).
        /// </param>
        /// <param name="type">
        /// Default Value: ratio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DerivedRatioInsightSpec(
            string label,
            string numeratorSeriesKey,
            string denominatorSeriesKey,
            global::PromptLayer.DerivedRatioInsightSpecType? type)
        {
            this.Type = type;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.NumeratorSeriesKey = numeratorSeriesKey ?? throw new global::System.ArgumentNullException(nameof(numeratorSeriesKey));
            this.DenominatorSeriesKey = denominatorSeriesKey ?? throw new global::System.ArgumentNullException(nameof(denominatorSeriesKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedRatioInsightSpec" /> class.
        /// </summary>
        public DerivedRatioInsightSpec()
        {
        }

    }
}