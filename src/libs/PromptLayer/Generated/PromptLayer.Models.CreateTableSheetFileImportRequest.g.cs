
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTableSheetFileImportRequest
    {
        /// <summary>
        /// Optional client-provided operation ID. A UUID is generated when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        public string? OperationId { get; set; }

        /// <summary>
        /// CSV file name. Must end with .csv.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// Base64-encoded CSV file content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_content_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileContentBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetFileImportRequest" /> class.
        /// </summary>
        /// <param name="fileName">
        /// CSV file name. Must end with .csv.
        /// </param>
        /// <param name="fileContentBase64">
        /// Base64-encoded CSV file content.
        /// </param>
        /// <param name="operationId">
        /// Optional client-provided operation ID. A UUID is generated when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetFileImportRequest(
            string fileName,
            string fileContentBase64,
            string? operationId)
        {
            this.OperationId = operationId;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileContentBase64 = fileContentBase64 ?? throw new global::System.ArgumentNullException(nameof(fileContentBase64));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetFileImportRequest" /> class.
        /// </summary>
        public CreateTableSheetFileImportRequest()
        {
        }

    }
}