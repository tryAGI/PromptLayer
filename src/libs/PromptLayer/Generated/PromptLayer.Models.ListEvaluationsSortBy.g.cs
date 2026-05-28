
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListEvaluationsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEvaluationsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEvaluationsSortBy value)
        {
            return value switch
            {
                ListEvaluationsSortBy.CreatedAt => "created_at",
                ListEvaluationsSortBy.Id => "id",
                ListEvaluationsSortBy.Name => "name",
                ListEvaluationsSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEvaluationsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListEvaluationsSortBy.CreatedAt,
                "id" => ListEvaluationsSortBy.Id,
                "name" => ListEvaluationsSortBy.Name,
                "updated_at" => ListEvaluationsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}