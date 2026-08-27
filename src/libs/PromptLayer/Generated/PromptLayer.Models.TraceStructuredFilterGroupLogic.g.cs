
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: AND
    /// </summary>
    public enum TraceStructuredFilterGroupLogic
    {
        /// <summary>
        ///
        /// </summary>
        And,
        /// <summary>
        ///
        /// </summary>
        Or,
        /// <summary>
        ///
        /// </summary>
        SpanAnd,
        /// <summary>
        ///
        /// </summary>
        SpanOr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceStructuredFilterGroupLogicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceStructuredFilterGroupLogic value)
        {
            return value switch
            {
                TraceStructuredFilterGroupLogic.And => "AND",
                TraceStructuredFilterGroupLogic.Or => "OR",
                TraceStructuredFilterGroupLogic.SpanAnd => "SPAN_AND",
                TraceStructuredFilterGroupLogic.SpanOr => "SPAN_OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceStructuredFilterGroupLogic? ToEnum(string value)
        {
            return value switch
            {
                "AND" => TraceStructuredFilterGroupLogic.And,
                "OR" => TraceStructuredFilterGroupLogic.Or,
                "SPAN_AND" => TraceStructuredFilterGroupLogic.SpanAnd,
                "SPAN_OR" => TraceStructuredFilterGroupLogic.SpanOr,
                _ => null,
            };
        }
    }
}