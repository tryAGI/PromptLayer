
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Internal metric identifier. One of `price` or `latency_ms`.
    /// </summary>
    public enum ExecutionMetadataMetricAggregateMetricKey
    {
        /// <summary>
        /// 
        /// </summary>
        LatencyMs,
        /// <summary>
        /// 
        /// </summary>
        Price,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionMetadataMetricAggregateMetricKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionMetadataMetricAggregateMetricKey value)
        {
            return value switch
            {
                ExecutionMetadataMetricAggregateMetricKey.LatencyMs => "latency_ms",
                ExecutionMetadataMetricAggregateMetricKey.Price => "price",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionMetadataMetricAggregateMetricKey? ToEnum(string value)
        {
            return value switch
            {
                "latency_ms" => ExecutionMetadataMetricAggregateMetricKey.LatencyMs,
                "price" => ExecutionMetadataMetricAggregateMetricKey.Price,
                _ => null,
            };
        }
    }
}