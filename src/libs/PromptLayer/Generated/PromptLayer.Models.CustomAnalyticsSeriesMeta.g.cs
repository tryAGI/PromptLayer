
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Metadata describing one series in a custom analytics query response.
    /// </summary>
    public sealed partial class CustomAnalyticsSeriesMeta
    {
        /// <summary>
        /// Series key (matches keys in each data row).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Human-readable label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Unit hint for rendering axes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CustomAnalyticsSeriesMetaUnitJsonConverter))]
        public global::PromptLayer.CustomAnalyticsSeriesMetaUnit? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnalyticsSeriesMeta" /> class.
        /// </summary>
        /// <param name="key">
        /// Series key (matches keys in each data row).
        /// </param>
        /// <param name="label">
        /// Human-readable label.
        /// </param>
        /// <param name="unit">
        /// Unit hint for rendering axes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomAnalyticsSeriesMeta(
            string? key,
            string? label,
            global::PromptLayer.CustomAnalyticsSeriesMetaUnit? unit)
        {
            this.Key = key;
            this.Label = label;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnalyticsSeriesMeta" /> class.
        /// </summary>
        public CustomAnalyticsSeriesMeta()
        {
        }

    }
}