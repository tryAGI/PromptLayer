
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptTemplate
    {
        /// <summary>
        /// Template metadata, including prompt name, tags, folder, and workspace fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.BasePromptTemplate PromptTemplate { get; set; }

        /// <summary>
        /// Version content and configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.PromptVersion PromptVersion { get; set; }

        /// <summary>
        /// Release labels to create or move to the newly created version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Identifiers from other systems.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        public global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? ExternalIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptTemplate" /> class.
        /// </summary>
        /// <param name="promptTemplate">
        /// Template metadata, including prompt name, tags, folder, and workspace fields.
        /// </param>
        /// <param name="promptVersion">
        /// Version content and configuration.
        /// </param>
        /// <param name="releaseLabels">
        /// Release labels to create or move to the newly created version.
        /// </param>
        /// <param name="externalIds">
        /// Identifiers from other systems.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePromptTemplate(
            global::PromptLayer.BasePromptTemplate promptTemplate,
            global::PromptLayer.PromptVersion promptVersion,
            global::System.Collections.Generic.IList<string>? releaseLabels,
            global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? externalIds)
        {
            this.PromptTemplate = promptTemplate ?? throw new global::System.ArgumentNullException(nameof(promptTemplate));
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.ReleaseLabels = releaseLabels;
            this.ExternalIds = externalIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptTemplate" /> class.
        /// </summary>
        public CreatePromptTemplate()
        {
        }

    }
}