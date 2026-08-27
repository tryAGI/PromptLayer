
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum RecalculateTableSheetScoreResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecalculateTableSheetScoreResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecalculateTableSheetScoreResponseStatus value)
        {
            return value switch
            {
                RecalculateTableSheetScoreResponseStatus.Completed => "completed",
                RecalculateTableSheetScoreResponseStatus.Failed => "failed",
                RecalculateTableSheetScoreResponseStatus.Queued => "queued",
                RecalculateTableSheetScoreResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecalculateTableSheetScoreResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RecalculateTableSheetScoreResponseStatus.Completed,
                "failed" => RecalculateTableSheetScoreResponseStatus.Failed,
                "queued" => RecalculateTableSheetScoreResponseStatus.Queued,
                "running" => RecalculateTableSheetScoreResponseStatus.Running,
                _ => null,
            };
        }
    }
}