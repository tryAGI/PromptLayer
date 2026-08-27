
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestAnalyticsCustomAnalyticsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Results in the same order as the input `customCharts` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customCharts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsResult> CustomCharts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsCustomAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="customCharts">
        /// Results in the same order as the input `customCharts` array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsCustomAnalyticsResponse(
            bool success,
            global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsResult> customCharts)
        {
            this.Success = success;
            this.CustomCharts = customCharts ?? throw new global::System.ArgumentNullException(nameof(customCharts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsCustomAnalyticsResponse" /> class.
        /// </summary>
        public RequestAnalyticsCustomAnalyticsResponse()
        {
        }

    }
}