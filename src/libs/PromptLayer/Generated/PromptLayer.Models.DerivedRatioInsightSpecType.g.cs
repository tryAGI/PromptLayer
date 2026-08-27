
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Default Value: ratio
    /// </summary>
    public enum DerivedRatioInsightSpecType
    {
        /// <summary>
        ///
        /// </summary>
        Ratio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DerivedRatioInsightSpecTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DerivedRatioInsightSpecType value)
        {
            return value switch
            {
                DerivedRatioInsightSpecType.Ratio => "ratio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DerivedRatioInsightSpecType? ToEnum(string value)
        {
            return value switch
            {
                "ratio" => DerivedRatioInsightSpecType.Ratio,
                _ => null,
            };
        }
    }
}