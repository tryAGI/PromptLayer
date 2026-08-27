
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum DerivedRatioInsightResultType
    {
        /// <summary>
        ///
        /// </summary>
        Ratio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DerivedRatioInsightResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DerivedRatioInsightResultType value)
        {
            return value switch
            {
                DerivedRatioInsightResultType.Ratio => "ratio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DerivedRatioInsightResultType? ToEnum(string value)
        {
            return value switch
            {
                "ratio" => DerivedRatioInsightResultType.Ratio,
                _ => null,
            };
        }
    }
}