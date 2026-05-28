
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// The request log field to filter on. Intent fields are virtual fields that classify request content by tone and do not require any additional logging configuration. `user_intent` classifies the user's message; valid values: `frustrated`, `satisfied`, `curious`. `agent_intent` classifies the agent's response; valid values: `apologetic`, `refusal`, `uncertain`. Intent fields support operators: `is`, `is_not`, `in`, `not_in`.
    /// </summary>
    public enum StructuredFilterField
    {
        /// <summary>
        /// `frustrated`, `satisfied`, `curious`. `agent_intent` classifies the agent's response; valid values: `apologetic`, `refusal`, `uncertain`. Intent fields support operators: `is`, `is_not`, `in`, `not_in`.
        /// </summary>
        AgentIntent,
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        Engine,
        /// <summary>
        /// 
        /// </summary>
        InputText,
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        InputVariableKeys,
        /// <summary>
        /// 
        /// </summary>
        InputVariables,
        /// <summary>
        /// 
        /// </summary>
        IsJson,
        /// <summary>
        /// 
        /// </summary>
        IsPlainText,
        /// <summary>
        /// 
        /// </summary>
        IsToolCall,
        /// <summary>
        /// 
        /// </summary>
        LatencyMs,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        MetadataKeys,
        /// <summary>
        /// 
        /// </summary>
        Output,
        /// <summary>
        /// 
        /// </summary>
        OutputKeys,
        /// <summary>
        /// 
        /// </summary>
        OutputText,
        /// <summary>
        /// 
        /// </summary>
        OutputTokens,
        /// <summary>
        /// 
        /// </summary>
        PlId,
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
        RequestEndTime,
        /// <summary>
        /// 
        /// </summary>
        RequestStartTime,
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
        /// <summary>
        /// `frustrated`, `satisfied`, `curious`. `agent_intent` classifies the agent's response; valid values: `apologetic`, `refusal`, `uncertain`. Intent fields support operators: `is`, `is_not`, `in`, `not_in`.
        /// </summary>
        UserIntent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredFilterFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredFilterField value)
        {
            return value switch
            {
                StructuredFilterField.AgentIntent => "agent_intent",
                StructuredFilterField.Cost => "cost",
                StructuredFilterField.Engine => "engine",
                StructuredFilterField.InputText => "input_text",
                StructuredFilterField.InputTokens => "input_tokens",
                StructuredFilterField.InputVariableKeys => "input_variable_keys",
                StructuredFilterField.InputVariables => "input_variables",
                StructuredFilterField.IsJson => "is_json",
                StructuredFilterField.IsPlainText => "is_plain_text",
                StructuredFilterField.IsToolCall => "is_tool_call",
                StructuredFilterField.LatencyMs => "latency_ms",
                StructuredFilterField.Metadata => "metadata",
                StructuredFilterField.MetadataKeys => "metadata_keys",
                StructuredFilterField.Output => "output",
                StructuredFilterField.OutputKeys => "output_keys",
                StructuredFilterField.OutputText => "output_text",
                StructuredFilterField.OutputTokens => "output_tokens",
                StructuredFilterField.PlId => "pl_id",
                StructuredFilterField.PromptId => "prompt_id",
                StructuredFilterField.PromptVersionNumber => "prompt_version_number",
                StructuredFilterField.ProviderType => "provider_type",
                StructuredFilterField.RequestEndTime => "request_end_time",
                StructuredFilterField.RequestStartTime => "request_start_time",
                StructuredFilterField.Status => "status",
                StructuredFilterField.Tags => "tags",
                StructuredFilterField.ToolNames => "tool_names",
                StructuredFilterField.UserIntent => "user_intent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredFilterField? ToEnum(string value)
        {
            return value switch
            {
                "agent_intent" => StructuredFilterField.AgentIntent,
                "cost" => StructuredFilterField.Cost,
                "engine" => StructuredFilterField.Engine,
                "input_text" => StructuredFilterField.InputText,
                "input_tokens" => StructuredFilterField.InputTokens,
                "input_variable_keys" => StructuredFilterField.InputVariableKeys,
                "input_variables" => StructuredFilterField.InputVariables,
                "is_json" => StructuredFilterField.IsJson,
                "is_plain_text" => StructuredFilterField.IsPlainText,
                "is_tool_call" => StructuredFilterField.IsToolCall,
                "latency_ms" => StructuredFilterField.LatencyMs,
                "metadata" => StructuredFilterField.Metadata,
                "metadata_keys" => StructuredFilterField.MetadataKeys,
                "output" => StructuredFilterField.Output,
                "output_keys" => StructuredFilterField.OutputKeys,
                "output_text" => StructuredFilterField.OutputText,
                "output_tokens" => StructuredFilterField.OutputTokens,
                "pl_id" => StructuredFilterField.PlId,
                "prompt_id" => StructuredFilterField.PromptId,
                "prompt_version_number" => StructuredFilterField.PromptVersionNumber,
                "provider_type" => StructuredFilterField.ProviderType,
                "request_end_time" => StructuredFilterField.RequestEndTime,
                "request_start_time" => StructuredFilterField.RequestStartTime,
                "status" => StructuredFilterField.Status,
                "tags" => StructuredFilterField.Tags,
                "tool_names" => StructuredFilterField.ToolNames,
                "user_intent" => StructuredFilterField.UserIntent,
                _ => null,
            };
        }
    }
}