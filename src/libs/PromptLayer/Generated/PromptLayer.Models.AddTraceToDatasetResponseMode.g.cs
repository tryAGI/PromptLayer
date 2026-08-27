
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// `"trace"` when the row was added from the full trace, or `"span"` when added from a specific span.
    /// </summary>
    public enum AddTraceToDatasetResponseMode
    {
        /// <summary>
        ///
        /// </summary>
        Span,
        /// <summary>
        ///
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddTraceToDatasetResponseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddTraceToDatasetResponseMode value)
        {
            return value switch
            {
                AddTraceToDatasetResponseMode.Span => "span",
                AddTraceToDatasetResponseMode.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddTraceToDatasetResponseMode? ToEnum(string value)
        {
            return value switch
            {
                "span" => AddTraceToDatasetResponseMode.Span,
                "trace" => AddTraceToDatasetResponseMode.Trace,
                _ => null,
            };
        }
    }
}