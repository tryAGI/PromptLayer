
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePromptTemplateResponsePromptTemplateDiscriminatorType
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
    public static class CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePromptTemplateResponsePromptTemplateDiscriminatorType value)
        {
            return value switch
            {
                CreatePromptTemplateResponsePromptTemplateDiscriminatorType.Chat => "chat",
                CreatePromptTemplateResponsePromptTemplateDiscriminatorType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePromptTemplateResponsePromptTemplateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => CreatePromptTemplateResponsePromptTemplateDiscriminatorType.Chat,
                "completion" => CreatePromptTemplateResponsePromptTemplateDiscriminatorType.Completion,
                _ => null,
            };
        }
    }
}