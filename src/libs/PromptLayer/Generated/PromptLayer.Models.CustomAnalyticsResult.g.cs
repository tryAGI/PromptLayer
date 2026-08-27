
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Computed result for a single custom analytics query.
    /// </summary>
    public sealed partial class CustomAnalyticsResult
    {
        /// <summary>
        /// Echoes the chart id from the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Chart title (echoed from request, or defaults to id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chartType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CustomAnalyticsResultChartTypeJsonConverter))]
        public global::PromptLayer.CustomAnalyticsResultChartType? ChartType { get; set; }

        /// <summary>
        /// Series descriptors (one entry per series). For single-metric charts the only entry has key `value`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSeriesMeta>? Series { get; set; }

        /// <summary>
        /// Rows of chart data. Each row has a `label` string and one numeric key per series. Time-series rows also include `bucketKey` (ISO date string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<object>? Data { get; set; }

        /// <summary>
        /// Computed ratio insights (multi-series charts only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("derivedInsights")]
        public global::System.Collections.Generic.IList<global::PromptLayer.DerivedRatioInsightResult>? DerivedInsights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnalyticsResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Echoes the chart id from the request.
        /// </param>
        /// <param name="title">
        /// Chart title (echoed from request, or defaults to id).
        /// </param>
        /// <param name="chartType"></param>
        /// <param name="series">
        /// Series descriptors (one entry per series). For single-metric charts the only entry has key `value`.
        /// </param>
        /// <param name="data">
        /// Rows of chart data. Each row has a `label` string and one numeric key per series. Time-series rows also include `bucketKey` (ISO date string).
        /// </param>
        /// <param name="derivedInsights">
        /// Computed ratio insights (multi-series charts only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomAnalyticsResult(
            string? id,
            string? title,
            global::PromptLayer.CustomAnalyticsResultChartType? chartType,
            global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSeriesMeta>? series,
            global::System.Collections.Generic.IList<object>? data,
            global::System.Collections.Generic.IList<global::PromptLayer.DerivedRatioInsightResult>? derivedInsights)
        {
            this.Id = id;
            this.Title = title;
            this.ChartType = chartType;
            this.Series = series;
            this.Data = data;
            this.DerivedInsights = derivedInsights;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnalyticsResult" /> class.
        /// </summary>
        public CustomAnalyticsResult()
        {
        }

    }
}