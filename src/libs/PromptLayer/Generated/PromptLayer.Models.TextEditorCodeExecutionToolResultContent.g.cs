
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Result from text editor code execution tool.
    /// </summary>
    public sealed partial class TextEditorCodeExecutionToolResultContent
    {
        /// <summary>
        /// Default Value: text_editor_code_execution_tool_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeJsonConverter))]
        public global::PromptLayer.TextEditorCodeExecutionToolResultContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public object? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEditorCodeExecutionToolResultContent" /> class.
        /// </summary>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_tool_result
        /// </param>
        /// <param name="content">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextEditorCodeExecutionToolResultContent(
            string toolUseId,
            global::PromptLayer.TextEditorCodeExecutionToolResultContentType? type,
            object? content)
        {
            this.Type = type;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEditorCodeExecutionToolResultContent" /> class.
        /// </summary>
        public TextEditorCodeExecutionToolResultContent()
        {
        }

    }
}