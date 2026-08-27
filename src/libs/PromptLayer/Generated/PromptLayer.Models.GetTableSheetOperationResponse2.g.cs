
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTableSheetOperationResponse2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Status of an asynchronous sheet import operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public global::PromptLayer.TableImportOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetOperationResponse2" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="operation">
        /// Status of an asynchronous sheet import operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTableSheetOperationResponse2(
            bool? success,
            global::PromptLayer.TableImportOperation? operation)
        {
            this.Success = success;
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableSheetOperationResponse2" /> class.
        /// </summary>
        public GetTableSheetOperationResponse2()
        {
        }

    }
}