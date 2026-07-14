#nullable enable

namespace PromptLayer
{
    public partial interface ISmartTablesClient
    {
        /// <summary>
        /// Create Table<br/>
        /// Create a new Table. By default, an empty Sheet 1 with a Column A text column and one empty row is created. Pass create_default_sheet: false to create a table without a default sheet. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableResponse> CreateTableAsync(

            global::PromptLayer.CreateTableRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Table<br/>
        /// Create a new Table. By default, an empty Sheet 1 with a Column A text column and one empty row is created. Pass create_default_sheet: false to create a table without a default sheet. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.CreateTableResponse>> CreateTableAsResponseAsync(

            global::PromptLayer.CreateTableRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Table<br/>
        /// Create a new Table. By default, an empty Sheet 1 with a Column A text column and one empty row is created. Pass create_default_sheet: false to create a table without a default sheet. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="title">
        /// Table title. Defaults to a unique 'Untitled Table' name if omitted.
        /// </param>
        /// <param name="folderId">
        /// Folder to place the table in.
        /// </param>
        /// <param name="createDefaultSheet">
        /// When true (default), creates Sheet 1 with a Column A text column and one empty row. When false, creates an empty table with no sheets.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.CreateTableResponse> CreateTableAsync(
            string? title = default,
            int? folderId = default,
            bool? createDefaultSheet = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}