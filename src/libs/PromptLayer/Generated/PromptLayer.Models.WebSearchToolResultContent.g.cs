
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Results from a web search tool invocation.
    /// </summary>
    public sealed partial class WebSearchToolResultContent
    {
        /// <summary>
        /// Default Value: web_search_tool_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeJsonConverter))]
        public global::PromptLayer.WebSearchToolResultContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::PromptLayer.WebSearchResult>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolResultContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: web_search_tool_result
        /// </param>
        /// <param name="toolUseId"></param>
        /// <param name="content">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolResultContent(
            string toolUseId,
            global::PromptLayer.WebSearchToolResultContentType? type,
            global::System.Collections.Generic.IList<global::PromptLayer.WebSearchResult>? content)
        {
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolResultContent" /> class.
        /// </summary>
        public WebSearchToolResultContent()
        {
        }
    }
}