
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TraceAnalyticsCustomAnalyticsQuery
    {
        /// <summary>
        /// Nested filter tree. AND/OR are cross-span; SPAN_AND/SPAN_OR require one and the same span to satisfy every/any branch (span-level fields only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_group")]
        public global::PromptLayer.TraceStructuredFilterGroup? FilterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customCharts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpec> CustomCharts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceAnalyticsCustomAnalyticsQuery" /> class.
        /// </summary>
        /// <param name="customCharts"></param>
        /// <param name="filterGroup">
        /// Nested filter tree. AND/OR are cross-span; SPAN_AND/SPAN_OR require one and the same span to satisfy every/any branch (span-level fields only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceAnalyticsCustomAnalyticsQuery(
            global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpec> customCharts,
            global::PromptLayer.TraceStructuredFilterGroup? filterGroup)
        {
            this.FilterGroup = filterGroup;
            this.CustomCharts = customCharts ?? throw new global::System.ArgumentNullException(nameof(customCharts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceAnalyticsCustomAnalyticsQuery" /> class.
        /// </summary>
        public TraceAnalyticsCustomAnalyticsQuery()
        {
        }

    }
}