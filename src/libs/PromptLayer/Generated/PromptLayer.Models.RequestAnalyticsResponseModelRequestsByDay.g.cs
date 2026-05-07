
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Map of model name → list of `[date, requestCount]` pairs.
    /// </summary>
    public sealed partial class RequestAnalyticsResponseModelRequestsByDay
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}