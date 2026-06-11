
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Definition for a single custom analytics query.
    /// </summary>
    public sealed partial class CustomAnalyticsSpec
    {
        /// <summary>
        /// Stable identifier for this chart in the response (alphanumeric, hyphens, underscores; max 64 chars). Must be unique within the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Optional display title (max 200 chars). Defaults to id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Chart visualization type. Overall aggregate charts (no timeSeries, no groupByField) must use `bar`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CustomAnalyticsSpecChartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.CustomAnalyticsSpecChartType ChartType { get; set; }

        /// <summary>
        /// Aggregation function. Omit when using `series` (multi-series mode).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CustomAnalyticsSpecMetricJsonConverter))]
        public global::PromptLayer.CustomAnalyticsSpecMetric? Metric { get; set; }

        /// <summary>
        /// Numeric field to aggregate. Required unless metric is `count` or using multi-series mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CustomAnalyticsSpecMetricFieldJsonConverter))]
        public global::PromptLayer.CustomAnalyticsSpecMetricField? MetricField { get; set; }

        /// <summary>
        /// Required when metric is `percentile`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public double? Percentile { get; set; }

        /// <summary>
        /// Multi-series mode: define two or more series. Omit metric/metricField/percentile when using this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSeriesSpec>? Series { get; set; }

        /// <summary>
        /// Ratio insights computed from series totals. Only valid in multi-series mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("derivedInsights")]
        public global::System.Collections.Generic.IList<global::PromptLayer.DerivedRatioInsightSpec>? DerivedInsights { get; set; }

        /// <summary>
        /// Break results down by this request log field. Cannot be combined with groupByMetadataKey.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupByField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CustomAnalyticsSpecGroupByFieldJsonConverter))]
        public global::PromptLayer.CustomAnalyticsSpecGroupByField? GroupByField { get; set; }

        /// <summary>
        /// Break results down by the values of this metadata key. Cannot be combined with groupByField.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupByMetadataKey")]
        public string? GroupByMetadataKey { get; set; }

        /// <summary>
        /// When true, bucket results over time (bucket size chosen automatically from the filter range).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeries")]
        public bool? TimeSeries { get; set; }

        /// <summary>
        /// Maximum number of group-by buckets to return.<br/>
        /// Default Value: 25
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnalyticsSpec" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier for this chart in the response (alphanumeric, hyphens, underscores; max 64 chars). Must be unique within the request.
        /// </param>
        /// <param name="chartType">
        /// Chart visualization type. Overall aggregate charts (no timeSeries, no groupByField) must use `bar`.
        /// </param>
        /// <param name="title">
        /// Optional display title (max 200 chars). Defaults to id.
        /// </param>
        /// <param name="metric">
        /// Aggregation function. Omit when using `series` (multi-series mode).
        /// </param>
        /// <param name="metricField">
        /// Numeric field to aggregate. Required unless metric is `count` or using multi-series mode.
        /// </param>
        /// <param name="percentile">
        /// Required when metric is `percentile`.
        /// </param>
        /// <param name="series">
        /// Multi-series mode: define two or more series. Omit metric/metricField/percentile when using this.
        /// </param>
        /// <param name="derivedInsights">
        /// Ratio insights computed from series totals. Only valid in multi-series mode.
        /// </param>
        /// <param name="groupByField">
        /// Break results down by this request log field. Cannot be combined with groupByMetadataKey.
        /// </param>
        /// <param name="groupByMetadataKey">
        /// Break results down by the values of this metadata key. Cannot be combined with groupByField.
        /// </param>
        /// <param name="timeSeries">
        /// When true, bucket results over time (bucket size chosen automatically from the filter range).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Maximum number of group-by buckets to return.<br/>
        /// Default Value: 25
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomAnalyticsSpec(
            string id,
            global::PromptLayer.CustomAnalyticsSpecChartType chartType,
            string? title,
            global::PromptLayer.CustomAnalyticsSpecMetric? metric,
            global::PromptLayer.CustomAnalyticsSpecMetricField? metricField,
            double? percentile,
            global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSeriesSpec>? series,
            global::System.Collections.Generic.IList<global::PromptLayer.DerivedRatioInsightSpec>? derivedInsights,
            global::PromptLayer.CustomAnalyticsSpecGroupByField? groupByField,
            string? groupByMetadataKey,
            bool? timeSeries,
            int? limit)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title;
            this.ChartType = chartType;
            this.Metric = metric;
            this.MetricField = metricField;
            this.Percentile = percentile;
            this.Series = series;
            this.DerivedInsights = derivedInsights;
            this.GroupByField = groupByField;
            this.GroupByMetadataKey = groupByMetadataKey;
            this.TimeSeries = timeSeries;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnalyticsSpec" /> class.
        /// </summary>
        public CustomAnalyticsSpec()
        {
        }

    }
}