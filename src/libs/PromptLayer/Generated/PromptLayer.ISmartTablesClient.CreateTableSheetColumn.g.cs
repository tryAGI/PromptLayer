#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Create Column<br/>
        /// Add a new column to a sheet. Non-text columns will generate cells for all existing rows. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableSheetColumnResponse> CreateTableSheetColumnAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.CreateTableSheetColumnRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Column<br/>
        /// Add a new column to a sheet. Non-text columns will generate cells for all existing rows. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateTableSheetColumnResponse>> CreateTableSheetColumnAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.CreateTableSheetColumnRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Column<br/>
        /// Add a new column to a sheet. Non-text columns will generate cells for all existing rows. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="title"></param>
        /// <param name="type">
        /// Smart Table column type. Use uppercase backend enum values. Input: TEXT. Reference (Tables only, not in legacy evaluation/workflow enums): COMPOSITION. Computed: all other listed values. Create requests also accept lowercase aliases (text, prompt_template, llm, code, score, comparison, composition), which are normalized to uppercase. Legacy DATASET columns are not creatable.
        /// </param>
        /// <param name="config">
        /// Type-specific column configuration.
        /// </param>
        /// <param name="dependencies">
        /// Column dependency edges for non-text columns.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableSheetColumnResponse> CreateTableSheetColumnAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            string title,
            global::PromptLayer.TableColumnType type,
            object? config = default,
            global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetColumnRequestDependencie>? dependencies = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}