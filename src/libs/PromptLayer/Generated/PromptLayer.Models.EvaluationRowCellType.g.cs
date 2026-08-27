
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationRowCellType
    {
        /// <summary>
        ///
        /// </summary>
        Eval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRowCellTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRowCellType value)
        {
            return value switch
            {
                EvaluationRowCellType.Eval => "eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRowCellType? ToEnum(string value)
        {
            return value switch
            {
                "eval" => EvaluationRowCellType.Eval,
                _ => null,
            };
        }
    }
}