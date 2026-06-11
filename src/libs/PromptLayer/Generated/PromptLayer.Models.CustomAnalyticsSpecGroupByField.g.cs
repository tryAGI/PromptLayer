
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Break results down by this request log field. Cannot be combined with groupByMetadataKey.
    /// </summary>
    public enum CustomAnalyticsSpecGroupByField
    {
        /// <summary>
        /// 
        /// </summary>
        Engine,
        /// <summary>
        /// 
        /// </summary>
        ErrorType,
        /// <summary>
        /// 
        /// </summary>
        InputVariableKeys,
        /// <summary>
        /// 
        /// </summary>
        MetadataKeys,
        /// <summary>
        /// 
        /// </summary>
        OutputKeys,
        /// <summary>
        /// 
        /// </summary>
        PromptId,
        /// <summary>
        /// 
        /// </summary>
        PromptVersionNumber,
        /// <summary>
        /// 
        /// </summary>
        ProviderType,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        ToolNames,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomAnalyticsSpecGroupByFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAnalyticsSpecGroupByField value)
        {
            return value switch
            {
                CustomAnalyticsSpecGroupByField.Engine => "engine",
                CustomAnalyticsSpecGroupByField.ErrorType => "error_type",
                CustomAnalyticsSpecGroupByField.InputVariableKeys => "input_variable_keys",
                CustomAnalyticsSpecGroupByField.MetadataKeys => "metadata_keys",
                CustomAnalyticsSpecGroupByField.OutputKeys => "output_keys",
                CustomAnalyticsSpecGroupByField.PromptId => "prompt_id",
                CustomAnalyticsSpecGroupByField.PromptVersionNumber => "prompt_version_number",
                CustomAnalyticsSpecGroupByField.ProviderType => "provider_type",
                CustomAnalyticsSpecGroupByField.Status => "status",
                CustomAnalyticsSpecGroupByField.Tags => "tags",
                CustomAnalyticsSpecGroupByField.ToolNames => "tool_names",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAnalyticsSpecGroupByField? ToEnum(string value)
        {
            return value switch
            {
                "engine" => CustomAnalyticsSpecGroupByField.Engine,
                "error_type" => CustomAnalyticsSpecGroupByField.ErrorType,
                "input_variable_keys" => CustomAnalyticsSpecGroupByField.InputVariableKeys,
                "metadata_keys" => CustomAnalyticsSpecGroupByField.MetadataKeys,
                "output_keys" => CustomAnalyticsSpecGroupByField.OutputKeys,
                "prompt_id" => CustomAnalyticsSpecGroupByField.PromptId,
                "prompt_version_number" => CustomAnalyticsSpecGroupByField.PromptVersionNumber,
                "provider_type" => CustomAnalyticsSpecGroupByField.ProviderType,
                "status" => CustomAnalyticsSpecGroupByField.Status,
                "tags" => CustomAnalyticsSpecGroupByField.Tags,
                "tool_names" => CustomAnalyticsSpecGroupByField.ToolNames,
                _ => null,
            };
        }
    }
}