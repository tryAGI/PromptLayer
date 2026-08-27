
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTableResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public global::PromptLayer.TableDetail? Table { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="table"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTableResponse(
            bool? success,
            global::PromptLayer.TableDetail? table)
        {
            this.Success = success;
            this.Table = table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableResponse" /> class.
        /// </summary>
        public GetTableResponse()
        {
        }

    }
}