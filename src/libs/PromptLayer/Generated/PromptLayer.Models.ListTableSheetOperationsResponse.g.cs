
#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListTableSheetOperationsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SheetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cells")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCells { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> StatusCounts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::PromptLayer.TableSheetOperation> ActiveOperations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetOperationsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="sheetId"></param>
        /// <param name="version"></param>
        /// <param name="totalCells"></param>
        /// <param name="statusCounts"></param>
        /// <param name="pendingCount"></param>
        /// <param name="activeOperations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTableSheetOperationsResponse(
            bool success,
            global::System.Guid sheetId,
            int version,
            int totalCells,
            global::System.Collections.Generic.Dictionary<string, int> statusCounts,
            int pendingCount,
            global::System.Collections.Generic.IList<global::PromptLayer.TableSheetOperation> activeOperations)
        {
            this.Success = success;
            this.SheetId = sheetId;
            this.Version = version;
            this.TotalCells = totalCells;
            this.StatusCounts = statusCounts ?? throw new global::System.ArgumentNullException(nameof(statusCounts));
            this.PendingCount = pendingCount;
            this.ActiveOperations = activeOperations ?? throw new global::System.ArgumentNullException(nameof(activeOperations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableSheetOperationsResponse" /> class.
        /// </summary>
        public ListTableSheetOperationsResponse()
        {
        }

    }
}