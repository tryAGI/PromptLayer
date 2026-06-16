
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTableSheetOperationConfirmationResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_confirmation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresConfirmation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmation_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfirmationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affected_cell_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AffectedCellCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetOperationConfirmationResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="requiresConfirmation"></param>
        /// <param name="confirmationToken"></param>
        /// <param name="affectedCellCount"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableSheetOperationConfirmationResponse(
            bool success,
            bool requiresConfirmation,
            string confirmationToken,
            int affectedCellCount,
            string message)
        {
            this.Success = success;
            this.RequiresConfirmation = requiresConfirmation;
            this.ConfirmationToken = confirmationToken ?? throw new global::System.ArgumentNullException(nameof(confirmationToken));
            this.AffectedCellCount = affectedCellCount;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableSheetOperationConfirmationResponse" /> class.
        /// </summary>
        public CreateTableSheetOperationConfirmationResponse()
        {
        }

    }
}