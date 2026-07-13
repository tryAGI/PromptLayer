
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceCustomChartSpecChartType
    {
        /// <summary>
        /// 
        /// </summary>
        Area,
        /// <summary>
        /// 
        /// </summary>
        Bar,
        /// <summary>
        /// 
        /// </summary>
        Donut,
        /// <summary>
        /// 
        /// </summary>
        Heatmap,
        /// <summary>
        /// 
        /// </summary>
        Histogram,
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        Pie,
        /// <summary>
        /// 
        /// </summary>
        Sunburst,
        /// <summary>
        /// 
        /// </summary>
        Treemap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceCustomChartSpecChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecChartType value)
        {
            return value switch
            {
                TraceCustomChartSpecChartType.Area => "area",
                TraceCustomChartSpecChartType.Bar => "bar",
                TraceCustomChartSpecChartType.Donut => "donut",
                TraceCustomChartSpecChartType.Heatmap => "heatmap",
                TraceCustomChartSpecChartType.Histogram => "histogram",
                TraceCustomChartSpecChartType.Line => "line",
                TraceCustomChartSpecChartType.Pie => "pie",
                TraceCustomChartSpecChartType.Sunburst => "sunburst",
                TraceCustomChartSpecChartType.Treemap => "treemap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecChartType? ToEnum(string value)
        {
            return value switch
            {
                "area" => TraceCustomChartSpecChartType.Area,
                "bar" => TraceCustomChartSpecChartType.Bar,
                "donut" => TraceCustomChartSpecChartType.Donut,
                "heatmap" => TraceCustomChartSpecChartType.Heatmap,
                "histogram" => TraceCustomChartSpecChartType.Histogram,
                "line" => TraceCustomChartSpecChartType.Line,
                "pie" => TraceCustomChartSpecChartType.Pie,
                "sunburst" => TraceCustomChartSpecChartType.Sunburst,
                "treemap" => TraceCustomChartSpecChartType.Treemap,
                _ => null,
            };
        }
    }
}