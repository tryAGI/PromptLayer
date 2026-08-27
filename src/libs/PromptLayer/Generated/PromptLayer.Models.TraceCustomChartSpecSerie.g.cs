
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TraceCustomChartSpecSerie
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecSerieMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TraceCustomChartSpecSerieMetric Metric { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecSerieMetricFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TraceCustomChartSpecSerieMetricField MetricField { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public double? Percentile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceCustomChartSpecSerie" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="label"></param>
        /// <param name="metric"></param>
        /// <param name="metricField"></param>
        /// <param name="percentile"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceCustomChartSpecSerie(
            string key,
            string label,
            global::PromptLayer.TraceCustomChartSpecSerieMetric metric,
            global::PromptLayer.TraceCustomChartSpecSerieMetricField metricField,
            double? percentile)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Metric = metric;
            this.MetricField = metricField;
            this.Percentile = percentile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceCustomChartSpecSerie" /> class.
        /// </summary>
        public TraceCustomChartSpecSerie()
        {
        }

    }
}