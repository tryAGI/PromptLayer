
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MediaContent
    {
        /// <summary>
        /// Default Value: media
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.MediaContentTypeJsonConverter))]
        public global::PromptLayer.MediaContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.Media Media { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContent" /> class.
        /// </summary>
        /// <param name="media"></param>
        /// <param name="type">
        /// Default Value: media
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaContent(
            global::PromptLayer.Media media,
            global::PromptLayer.MediaContentType? type)
        {
            this.Type = type;
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContent" /> class.
        /// </summary>
        public MediaContent()
        {
        }
    }
}