
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveSkillCollectionVersionRequest
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_updates")]
        public global::System.Collections.Generic.IList<global::PromptLayer.FileUpdate>? FileUpdates { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moves")]
        public global::System.Collections.Generic.IList<global::PromptLayer.FileMove>? Moves { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletes")]
        public global::System.Collections.Generic.IList<string>? Deletes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_label")]
        public string? ReleaseLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveSkillCollectionVersionRequest" /> class.
        /// </summary>
        /// <param name="fileUpdates">
        /// Default Value: []
        /// </param>
        /// <param name="moves">
        /// Default Value: []
        /// </param>
        /// <param name="deletes">
        /// Default Value: []
        /// </param>
        /// <param name="commitMessage"></param>
        /// <param name="releaseLabel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveSkillCollectionVersionRequest(
            global::System.Collections.Generic.IList<global::PromptLayer.FileUpdate>? fileUpdates,
            global::System.Collections.Generic.IList<global::PromptLayer.FileMove>? moves,
            global::System.Collections.Generic.IList<string>? deletes,
            string? commitMessage,
            string? releaseLabel)
        {
            this.FileUpdates = fileUpdates;
            this.Moves = moves;
            this.Deletes = deletes;
            this.CommitMessage = commitMessage;
            this.ReleaseLabel = releaseLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveSkillCollectionVersionRequest" /> class.
        /// </summary>
        public SaveSkillCollectionVersionRequest()
        {
        }

    }
}