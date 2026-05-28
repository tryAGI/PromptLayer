
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Parameters to shallow-merge into existing model parameters. Existing keys not provided are preserved.
    /// </summary>
    public sealed partial class PatchPromptTemplateVersionModelParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}