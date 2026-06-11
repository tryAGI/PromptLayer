
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// One series in a multi-series custom analytics query.
    /// </summary>
    public sealed partial class CustomAnalyticsSeriesSpec
    {
        /// <summary>
        /// Unique identifier for this series within the chart (alphanumeric, hyphens, underscores; max 64 chars).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Human-readable series label shown in chart legends (max 120 chars).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Aggregation function for this series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CustomAnalyticsSeriesSpecMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.CustomAnalyticsSeriesSpecMetric Metric { get; set; }

        /// <summary>
        /// Numeric field to aggregate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CustomAnalyticsSeriesSpecMetricFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.CustomAnalyticsSeriesSpecMetricField MetricField { get; set; }

        /// <summary>
        /// Required when metric is `percentile`; omit otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public double? Percentile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnalyticsSeriesSpec" /> class.
        /// </summary>
        /// <param name="key">
        /// Unique identifier for this series within the chart (alphanumeric, hyphens, underscores; max 64 chars).
        /// </param>
        /// <param name="label">
        /// Human-readable series label shown in chart legends (max 120 chars).
        /// </param>
        /// <param name="metric">
        /// Aggregation function for this series.
        /// </param>
        /// <param name="metricField">
        /// Numeric field to aggregate.
        /// </param>
        /// <param name="percentile">
        /// Required when metric is `percentile`; omit otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomAnalyticsSeriesSpec(
            string key,
            string label,
            global::PromptLayer.CustomAnalyticsSeriesSpecMetric metric,
            global::PromptLayer.CustomAnalyticsSeriesSpecMetricField metricField,
            double? percentile)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Metric = metric;
            this.MetricField = metricField;
            this.Percentile = percentile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnalyticsSeriesSpec" /> class.
        /// </summary>
        public CustomAnalyticsSeriesSpec()
        {
        }

    }
}