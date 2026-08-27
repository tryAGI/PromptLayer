
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public enum ListPromptTemplateItemPromptTemplateDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Chat,
        /// <summary>
        ///
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPromptTemplateItemPromptTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPromptTemplateItemPromptTemplateDiscriminatorType value)
        {
            return value switch
            {
                ListPromptTemplateItemPromptTemplateDiscriminatorType.Chat => "chat",
                ListPromptTemplateItemPromptTemplateDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPromptTemplateItemPromptTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ListPromptTemplateItemPromptTemplateDiscriminatorType.Chat,
                "completion" => ListPromptTemplateItemPromptTemplateDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}