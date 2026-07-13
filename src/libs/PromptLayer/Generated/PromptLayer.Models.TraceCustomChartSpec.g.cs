
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// One analytics query. Each chart must use all trace-level or all span-level fields — mixed levels are rejected. Span-level charts do not support timeSeries or metadata breakdowns.
    /// </summary>
    public sealed partial class TraceCustomChartSpec
    {
        /// <summary>
        /// Stable chart id, unique within the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecChartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TraceCustomChartSpecChartType ChartType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecMetricJsonConverter))]
        public global::PromptLayer.TraceCustomChartSpecMetric? Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecMetricFieldJsonConverter))]
        public global::PromptLayer.TraceCustomChartSpecMetricField? MetricField { get; set; }

        /// <summary>
        /// Required when metric is percentile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public double? Percentile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupByField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecGroupByFieldJsonConverter))]
        public global::PromptLayer.TraceCustomChartSpecGroupByField? GroupByField { get; set; }

        /// <summary>
        /// Heatmap charts only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondaryGroupByField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecSecondaryGroupByFieldJsonConverter))]
        public global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField? SecondaryGroupByField { get; set; }

        /// <summary>
        /// Histogram charts only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("histogramField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecHistogramFieldJsonConverter))]
        public global::PromptLayer.TraceCustomChartSpecHistogramField? HistogramField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("histogramInterval")]
        public double? HistogramInterval { get; set; }

        /// <summary>
        /// Treemap and sunburst charts only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchyFields")]
        public global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpecHierarchyField>? HierarchyFields { get; set; }

        /// <summary>
        /// Not supported with span-level fields
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeries")]
        public bool? TimeSeries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeBucket")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TraceCustomChartSpecTimeBucketJsonConverter))]
        public global::PromptLayer.TraceCustomChartSpecTimeBucket? TimeBucket { get; set; }

        /// <summary>
        /// Default Value: 25
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Multi-series mode; omit metric/metricField when using this
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpecSerie>? Series { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceCustomChartSpec" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable chart id, unique within the request
        /// </param>
        /// <param name="chartType"></param>
        /// <param name="title"></param>
        /// <param name="metric"></param>
        /// <param name="metricField"></param>
        /// <param name="percentile">
        /// Required when metric is percentile
        /// </param>
        /// <param name="groupByField"></param>
        /// <param name="secondaryGroupByField">
        /// Heatmap charts only
        /// </param>
        /// <param name="histogramField">
        /// Histogram charts only
        /// </param>
        /// <param name="histogramInterval"></param>
        /// <param name="hierarchyFields">
        /// Treemap and sunburst charts only
        /// </param>
        /// <param name="timeSeries">
        /// Not supported with span-level fields
        /// </param>
        /// <param name="timeBucket"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="series">
        /// Multi-series mode; omit metric/metricField when using this
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceCustomChartSpec(
            string id,
            global::PromptLayer.TraceCustomChartSpecChartType chartType,
            string? title,
            global::PromptLayer.TraceCustomChartSpecMetric? metric,
            global::PromptLayer.TraceCustomChartSpecMetricField? metricField,
            double? percentile,
            global::PromptLayer.TraceCustomChartSpecGroupByField? groupByField,
            global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField? secondaryGroupByField,
            global::PromptLayer.TraceCustomChartSpecHistogramField? histogramField,
            double? histogramInterval,
            global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpecHierarchyField>? hierarchyFields,
            bool? timeSeries,
            global::PromptLayer.TraceCustomChartSpecTimeBucket? timeBucket,
            int? limit,
            global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpecSerie>? series)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title;
            this.ChartType = chartType;
            this.Metric = metric;
            this.MetricField = metricField;
            this.Percentile = percentile;
            this.GroupByField = groupByField;
            this.SecondaryGroupByField = secondaryGroupByField;
            this.HistogramField = histogramField;
            this.HistogramInterval = histogramInterval;
            this.HierarchyFields = hierarchyFields;
            this.TimeSeries = timeSeries;
            this.TimeBucket = timeBucket;
            this.Limit = limit;
            this.Series = series;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceCustomChartSpec" /> class.
        /// </summary>
        public TraceCustomChartSpec()
        {
        }

    }
}