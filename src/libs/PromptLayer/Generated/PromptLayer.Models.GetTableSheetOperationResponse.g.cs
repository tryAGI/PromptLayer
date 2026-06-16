
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTableSheetOperationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableSheetOperation Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetOperationResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="operation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTableSheetOperationResponse(
            bool success,
            global::PromptLayer.TableSheetOperation operation)
        {
            this.Success = success;
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetOperationResponse" /> class.
        /// </summary>
        public GetTableSheetOperationResponse()
        {
        }

    }
}