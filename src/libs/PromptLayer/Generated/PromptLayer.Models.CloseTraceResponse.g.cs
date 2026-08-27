
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CloseTraceResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closure")]
        public global::PromptLayer.CloseTraceResponseClosure? Closure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloseTraceResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="closure"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloseTraceResponse(
            bool? success,
            global::PromptLayer.CloseTraceResponseClosure? closure)
        {
            this.Success = success;
            this.Closure = closure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloseTraceResponse" /> class.
        /// </summary>
        public CloseTraceResponse()
        {
        }

    }
}