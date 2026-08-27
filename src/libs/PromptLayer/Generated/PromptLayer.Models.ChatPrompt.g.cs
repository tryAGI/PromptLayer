
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatPrompt
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.MessagesItem> Messages { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.IList<global::PromptLayer.Function>? Functions { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::PromptLayer.Tool>? Tools { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.MessageFunctionCall, object>))]
        public global::PromptLayer.AnyOf<string, global::PromptLayer.MessageFunctionCall, object>? FunctionCall { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.ChatToolChoice, object>))]
        public global::PromptLayer.AnyOf<string, global::PromptLayer.ChatToolChoice, object>? ToolChoice { get; set; }

        /// <summary>
        /// Default Value: chat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.ChatPromptTypeJsonConverter))]
        public global::PromptLayer.ChatPromptType? Type { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        public global::System.Collections.Generic.IList<string>? InputVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatPrompt" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="functions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tools">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="functionCall">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolChoice">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: chat
        /// </param>
        /// <param name="inputVariables">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatPrompt(
            global::System.Collections.Generic.IList<global::PromptLayer.MessagesItem> messages,
            global::System.Collections.Generic.IList<global::PromptLayer.Function>? functions,
            global::System.Collections.Generic.IList<global::PromptLayer.Tool>? tools,
            global::PromptLayer.AnyOf<string, global::PromptLayer.MessageFunctionCall, object>? functionCall,
            global::PromptLayer.AnyOf<string, global::PromptLayer.ChatToolChoice, object>? toolChoice,
            global::PromptLayer.ChatPromptType? type,
            global::System.Collections.Generic.IList<string>? inputVariables)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Functions = functions;
            this.Tools = tools;
            this.FunctionCall = functionCall;
            this.ToolChoice = toolChoice;
            this.Type = type;
            this.InputVariables = inputVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatPrompt" /> class.
        /// </summary>
        public ChatPrompt()
        {
        }

    }
}