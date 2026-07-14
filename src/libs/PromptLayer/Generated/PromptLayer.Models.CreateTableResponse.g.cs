
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PromptLayer.TableDetail Table { get; set; }

        /// <summary>
        /// The default sheet created when create_default_sheet is true. Omitted when create_default_sheet is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_sheet")]
        public global::PromptLayer.Sheet? DefaultSheet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="table"></param>
        /// <param name="message"></param>
        /// <param name="defaultSheet">
        /// The default sheet created when create_default_sheet is true. Omitted when create_default_sheet is false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableResponse(
            bool success,
            global::PromptLayer.TableDetail table,
            string? message,
            global::PromptLayer.Sheet? defaultSheet)
        {
            this.Success = success;
            this.Message = message;
            this.Table = table ?? throw new global::System.ArgumentNullException(nameof(table));
            this.DefaultSheet = defaultSheet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableResponse" /> class.
        /// </summary>
        public CreateTableResponse()
        {
        }

    }
}