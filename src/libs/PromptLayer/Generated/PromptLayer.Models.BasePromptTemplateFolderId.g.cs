
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// The ID of the folder to publish the prompt template into. If omitted, the prompt is created at the workspace root. Use Resolve Folder ID by Path to look up an ID from a path, or Create Folder to make one.
    /// </summary>
    public sealed partial class BasePromptTemplateFolderId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}