
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// The reason spans were rejected. Currently only `trace_closed` is possible. Only present when one or more spans were rejected.
    /// </summary>
    public enum CreateSpansBulkResponseRejectionReason
    {
        /// <summary>
        /// 
        /// </summary>
        TraceClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpansBulkResponseRejectionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpansBulkResponseRejectionReason value)
        {
            return value switch
            {
                CreateSpansBulkResponseRejectionReason.TraceClosed => "trace_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpansBulkResponseRejectionReason? ToEnum(string value)
        {
            return value switch
            {
                "trace_closed" => CreateSpansBulkResponseRejectionReason.TraceClosed,
                _ => null,
            };
        }
    }
}