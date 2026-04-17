
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSkillCollectionPublicFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSkillCollectionPublicFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSkillCollectionPublicFormat value)
        {
            return value switch
            {
                GetSkillCollectionPublicFormat.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSkillCollectionPublicFormat? ToEnum(string value)
        {
            return value switch
            {
                "zip" => GetSkillCollectionPublicFormat.Zip,
                _ => null,
            };
        }
    }
}