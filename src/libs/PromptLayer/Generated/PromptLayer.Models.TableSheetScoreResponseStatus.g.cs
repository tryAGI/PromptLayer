
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TableSheetScoreResponseStatus
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
    public static class TableSheetScoreResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSheetScoreResponseStatus value)
        {
            return value switch
            {
                TableSheetScoreResponseStatus.Completed => "completed",
                TableSheetScoreResponseStatus.Failed => "failed",
                TableSheetScoreResponseStatus.Queued => "queued",
                TableSheetScoreResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSheetScoreResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TableSheetScoreResponseStatus.Completed,
                "failed" => TableSheetScoreResponseStatus.Failed,
                "queued" => TableSheetScoreResponseStatus.Queued,
                "running" => TableSheetScoreResponseStatus.Running,
                _ => null,
            };
        }
    }
}