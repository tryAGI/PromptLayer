
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Custom key-value pairs for tracking additional request information. Keys are limited to 1024 characters.<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class LogRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}