
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTableSheetResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="sheet">
        /// A sheet within a Table.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetResponse(
            bool? success,
            global::PromptLayer.Sheet? sheet)
        {
            this.Success = success;
            this.Sheet = sheet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetResponse" /> class.
        /// </summary>
        public CreateTableSheetResponse()
        {
        }

    }
}