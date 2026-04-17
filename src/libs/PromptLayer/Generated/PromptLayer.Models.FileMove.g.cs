
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileMove
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMove" /> class.
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileMove(
            string oldPath,
            string newPath)
        {
            this.OldPath = oldPath ?? throw new global::System.ArgumentNullException(nameof(oldPath));
            this.NewPath = newPath ?? throw new global::System.ArgumentNullException(nameof(newPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMove" /> class.
        /// </summary>
        public FileMove()
        {
        }
    }
}