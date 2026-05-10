
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSkillCollectionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.SkillCollection> SkillCollections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSkillCollectionsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="skillCollections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSkillCollectionsResponse(
            bool success,
            global::System.Collections.Generic.IList<global::PromptLayer.SkillCollection> skillCollections)
        {
            this.Success = success;
            this.SkillCollections = skillCollections ?? throw new global::System.ArgumentNullException(nameof(skillCollections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSkillCollectionsResponse" /> class.
        /// </summary>
        public ListSkillCollectionsResponse()
        {
        }

    }
}