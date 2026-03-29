
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextContent
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.TextContentTypeJsonConverter))]
        public global::PromptLayer.TextContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Citations and references within the text (web citations, file citations, map citations, container file citations).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>? Annotations { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thought_signature")]
        public string? ThoughtSignature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="annotations">
        /// Citations and references within the text (web citations, file citations, map citations, container file citations).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="thoughtSignature">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextContent(
            string text,
            global::PromptLayer.TextContentType? type,
            string? id,
            global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>? annotations,
            string? thoughtSignature)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Id = id;
            this.Annotations = annotations;
            this.ThoughtSignature = thoughtSignature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        public TextContent()
        {
        }
    }
}