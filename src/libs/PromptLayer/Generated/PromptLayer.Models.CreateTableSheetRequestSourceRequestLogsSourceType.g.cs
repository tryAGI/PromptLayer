
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTableSheetRequestSourceRequestLogsSourceType
    {
        /// <summary>
        ///
        /// </summary>
        RequestLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTableSheetRequestSourceRequestLogsSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTableSheetRequestSourceRequestLogsSourceType value)
        {
            return value switch
            {
                CreateTableSheetRequestSourceRequestLogsSourceType.RequestLogs => "request_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTableSheetRequestSourceRequestLogsSourceType? ToEnum(string value)
        {
            return value switch
            {
                "request_logs" => CreateTableSheetRequestSourceRequestLogsSourceType.RequestLogs,
                _ => null,
            };
        }
    }
}