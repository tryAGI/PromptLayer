
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem
    {
        /// <summary>
        /// Prompt template name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Restrict to these specific template version numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_numbers")]
        public global::System.Collections.Generic.IList<int>? VersionNumbers { get; set; }

        /// <summary>
        /// Restrict to template versions tagged with these release labels (e.g. `prod`, `staging`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Prompt template name.
        /// </param>
        /// <param name="versionNumbers">
        /// Restrict to these specific template version numbers.
        /// </param>
        /// <param name="labels">
        /// Restrict to template versions tagged with these release labels (e.g. `prod`, `staging`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem(
            string name,
            global::System.Collections.Generic.IList<int>? versionNumbers,
            global::System.Collections.Generic.IList<string>? labels)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VersionNumbers = versionNumbers;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem()
        {
        }
    }
}