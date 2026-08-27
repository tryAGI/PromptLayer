
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CloseTraceResponseClosureStatus
    {
        /// <summary>
        ///
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloseTraceResponseClosureStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloseTraceResponseClosureStatus value)
        {
            return value switch
            {
                CloseTraceResponseClosureStatus.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloseTraceResponseClosureStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => CloseTraceResponseClosureStatus.Closed,
                _ => null,
            };
        }
    }
}