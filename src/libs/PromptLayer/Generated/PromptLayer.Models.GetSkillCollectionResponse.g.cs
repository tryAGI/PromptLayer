
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSkillCollectionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// A skill collection container in the public API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.SkillCollection SkillCollection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.SkillCollectionVersion, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.OneOf<global::PromptLayer.SkillCollectionVersion, object> Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkillCollectionResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="skillCollection">
        /// A skill collection container in the public API.
        /// </param>
        /// <param name="files"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSkillCollectionResponse(
            bool success,
            global::PromptLayer.SkillCollection skillCollection,
            global::System.Collections.Generic.Dictionary<string, string> files,
            global::PromptLayer.OneOf<global::PromptLayer.SkillCollectionVersion, object> version)
        {
            this.Success = success;
            this.SkillCollection = skillCollection ?? throw new global::System.ArgumentNullException(nameof(skillCollection));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSkillCollectionResponse" /> class.
        /// </summary>
        public GetSkillCollectionResponse()
        {
        }

    }
}