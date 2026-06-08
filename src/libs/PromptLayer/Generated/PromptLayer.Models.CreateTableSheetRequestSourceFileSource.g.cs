
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetRequestSourceFileSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.CreateTableSheetRequestSourceFileSourceTypeJsonConverter))]
        public global::PromptLayer.CreateTableSheetRequestSourceFileSourceType Type { get; set; }

        /// <summary>
        /// Original file name (must end in .csv or .json).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// Base64-encoded file content (max 100 MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_content_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileContentBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetRequestSourceFileSource" /> class.
        /// </summary>
        /// <param name="fileName">
        /// Original file name (must end in .csv or .json).
        /// </param>
        /// <param name="fileContentBase64">
        /// Base64-encoded file content (max 100 MB).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetRequestSourceFileSource(
            string fileName,
            string fileContentBase64,
            global::PromptLayer.CreateTableSheetRequestSourceFileSourceType type)
        {
            this.Type = type;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileContentBase64 = fileContentBase64 ?? throw new global::System.ArgumentNullException(nameof(fileContentBase64));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetRequestSourceFileSource" /> class.
        /// </summary>
        public CreateTableSheetRequestSourceFileSource()
        {
        }

    }
}