
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Present on status="error". Includes `type` and `message`.
    /// </summary>
    public sealed partial class TestExecuteToolResponseResultError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}