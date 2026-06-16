#nullable enable

namespace PromptLayer
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Configure Table Sheet Score<br/>
        /// Configure scoring for a Table sheet. This endpoint updates the configuration and returns whether recalculation is required; it does not queue score calculation. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ConfigureTableSheetScoreResponse> ConfigureTableSheetScoreAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.ConfigureTableSheetScoreRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure Table Sheet Score<br/>
        /// Configure scoring for a Table sheet. This endpoint updates the configuration and returns whether recalculation is required; it does not queue score calculation. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PromptLayer.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.AutoSDKHttpResponse<global::PromptLayer.ConfigureTableSheetScoreResponse>> ConfigureTableSheetScoreAsResponseAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,

            global::PromptLayer.ConfigureTableSheetScoreRequest request,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure Table Sheet Score<br/>
        /// Configure scoring for a Table sheet. This endpoint updates the configuration and returns whether recalculation is required; it does not queue score calculation. Requests are scoped to the workspace associated with the API key; table, sheet, column, cell, operation, and version IDs must belong to that workspace.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="sheetId"></param>
        /// <param name="scoreType">
        /// Scoring mode. Required when score_config is provided.
        /// </param>
        /// <param name="scoreConfig">
        /// Explicit score configuration.
        /// </param>
        /// <param name="columnIds">
        /// Column IDs to score.
        /// </param>
        /// <param name="columnNames">
        /// Column titles to score. Titles must be unique in the sheet.
        /// </param>
        /// <param name="code">
        /// Custom scoring code.
        /// </param>
        /// <param name="codeLanguage">
        /// Default Value: PYTHON
        /// </param>
        /// <param name="trueValues">
        /// Values treated as true for boolean scoring.
        /// </param>
        /// <param name="falseValues">
        /// Values treated as false for boolean scoring.
        /// </param>
        /// <param name="assertionAggregation">
        /// Aggregation mode for assertion-style boolean scoring.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PromptLayer.ConfigureTableSheetScoreResponse> ConfigureTableSheetScoreAsync(
            global::System.Guid tableId,
            global::System.Guid sheetId,
            global::PromptLayer.ConfigureTableSheetScoreRequestScoreType? scoreType = default,
            object? scoreConfig = default,
            global::System.Collections.Generic.IList<global::System.Guid>? columnIds = default,
            global::System.Collections.Generic.IList<string>? columnNames = default,
            string? code = default,
            global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage? codeLanguage = default,
            global::System.Collections.Generic.IList<string>? trueValues = default,
            global::System.Collections.Generic.IList<string>? falseValues = default,
            global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation? assertionAggregation = default,
            global::PromptLayer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}