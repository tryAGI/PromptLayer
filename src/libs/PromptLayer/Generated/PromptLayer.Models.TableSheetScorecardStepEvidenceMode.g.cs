
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TableSheetScorecardStepEvidenceMode
    {
        /// <summary>
        /// 
        /// </summary>
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        Raw,
        /// <summary>
        /// 
        /// </summary>
        Summary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableSheetScorecardStepEvidenceModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScorecardStepEvidenceMode value)
        {
            return value switch
            {
                TableSheetScorecardStepEvidenceMode.Hidden => "hidden",
                TableSheetScorecardStepEvidenceMode.Raw => "raw",
                TableSheetScorecardStepEvidenceMode.Summary => "summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScorecardStepEvidenceMode? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => TableSheetScorecardStepEvidenceMode.Hidden,
                "raw" => TableSheetScorecardStepEvidenceMode.Raw,
                "summary" => TableSheetScorecardStepEvidenceMode.Summary,
                _ => null,
            };
        }
    }
}