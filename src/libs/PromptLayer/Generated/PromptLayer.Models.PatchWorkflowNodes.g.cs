
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Node updates keyed by node name. Provide an object to add/update a node, or null to remove a node. Node configuration is deep-merged; dependencies are replaced.
    /// </summary>
    public sealed partial class PatchWorkflowNodes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}