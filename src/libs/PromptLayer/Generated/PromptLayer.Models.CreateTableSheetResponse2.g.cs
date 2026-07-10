
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        public string? OperationId { get; set; }

        /// <summary>
        /// Status of an asynchronous sheet import operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public global::PromptLayer.TableImportOperation? Operation { get; set; }

        /// <summary>
        /// A sheet within a Table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet")]
        public global::PromptLayer.Sheet? Sheet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetResponse2" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="operationId"></param>
        /// <param name="operation">
        /// Status of an asynchronous sheet import operation.
        /// </param>
        /// <param name="sheet">
        /// A sheet within a Table.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetResponse2(
            bool? success,
            string? message,
            string? operationId,
            global::PromptLayer.TableImportOperation? operation,
            global::PromptLayer.Sheet? sheet)
        {
            this.Success = success;
            this.Message = message;
            this.OperationId = operationId;
            this.Operation = operation;
            this.Sheet = sheet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetResponse2" /> class.
        /// </summary>
        public CreateTableSheetResponse2()
        {
        }

    }
}