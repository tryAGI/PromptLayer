
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem), TypeInfoPropertyName = "ContentItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ThinkingContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OutputMediaContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ServerToolUseContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchToolResultContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeExecutionResultContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpListToolsContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpCallContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalRequestContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalResponseContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BashCodeExecutionToolResultContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallOutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallOutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptContentItemDiscriminatorType), TypeInfoPropertyName = "CompletionPromptContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptTemplateFormat), TypeInfoPropertyName = "CompletionPromptTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptType), TypeInfoPropertyName = "CompletionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FileAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MapAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContainerFileAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextContentType), TypeInfoPropertyName = "TextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>), TypeInfoPropertyName = "OneOfWebAnnotationFileAnnotationMapAnnotationContainerFileAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ThinkingContentType), TypeInfoPropertyName = "ThinkingContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Media))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaFormat), TypeInfoPropertyName = "MediaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ImageContentType), TypeInfoPropertyName = "ImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaContentType), TypeInfoPropertyName = "MediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaVariableType), TypeInfoPropertyName = "MediaVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OutputMediaContentType), TypeInfoPropertyName = "OutputMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OutputMediaContentMediaType), TypeInfoPropertyName = "OutputMediaContentMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeContentType), TypeInfoPropertyName = "CodeContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ServerToolUseContentType), TypeInfoPropertyName = "ServerToolUseContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchResultType), TypeInfoPropertyName = "WebSearchResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchToolResultContentType), TypeInfoPropertyName = "WebSearchToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.WebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeExecutionResultContentType), TypeInfoPropertyName = "CodeExecutionResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpListToolsContentType), TypeInfoPropertyName = "McpListToolsContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, object, object>), TypeInfoPropertyName = "AnyOfStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpCallContentType), TypeInfoPropertyName = "McpCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalRequestContentType), TypeInfoPropertyName = "McpApprovalRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalResponseContentType), TypeInfoPropertyName = "McpApprovalResponseContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BashCodeExecutionToolResultContentType), TypeInfoPropertyName = "BashCodeExecutionToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContentType), TypeInfoPropertyName = "TextEditorCodeExecutionToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallContentType), TypeInfoPropertyName = "ShellCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallOutputContentType), TypeInfoPropertyName = "ShellCallOutputContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallContentType), TypeInfoPropertyName = "ApplyPatchCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallOutputContentType), TypeInfoPropertyName = "ApplyPatchCallOutputContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BuiltInTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BuiltInToolType), TypeInfoPropertyName = "BuiltInToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessageTemplateFormat), TypeInfoPropertyName = "SystemMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem2), TypeInfoPropertyName = "ContentItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessageContentItemDiscriminatorType), TypeInfoPropertyName = "SystemMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessageTemplateFormat), TypeInfoPropertyName = "UserMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem3), TypeInfoPropertyName = "ContentItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessageContentItemDiscriminatorType), TypeInfoPropertyName = "UserMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessageTemplateFormat), TypeInfoPropertyName = "AssistantMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item), TypeInfoPropertyName = "ContentVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType), TypeInfoPropertyName = "AssistantMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessageTemplateFormat), TypeInfoPropertyName = "FunctionMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item2), TypeInfoPropertyName = "ContentVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType), TypeInfoPropertyName = "FunctionMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessageTemplateFormat), TypeInfoPropertyName = "DeveloperMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem4), TypeInfoPropertyName = "ContentItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminatorType), TypeInfoPropertyName = "DeveloperMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MessagesItem), TypeInfoPropertyName = "MessagesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPromptMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPromptMessageDiscriminatorRole), TypeInfoPropertyName = "ChatPromptMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::PromptLayer.MessageFunctionCall, object>), TypeInfoPropertyName = "AnyOfStringMessageFunctionCallObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::PromptLayer.ChatToolChoice, object>), TypeInfoPropertyName = "AnyOfStringChatToolChoiceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPromptType), TypeInfoPropertyName = "ChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate), TypeInfoPropertyName = "PromptTemplate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate2), TypeInfoPropertyName = "PromptTemplate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate3), TypeInfoPropertyName = "PromptTemplate32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate4), TypeInfoPropertyName = "PromptTemplate42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessageTemplateFormat), TypeInfoPropertyName = "ToolMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem5), TypeInfoPropertyName = "ContentItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessageContentItemDiscriminatorType), TypeInfoPropertyName = "ToolMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolDiscriminatorType), TypeInfoPropertyName = "ToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageTemplateFormat), TypeInfoPropertyName = "PlaceholderMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item3), TypeInfoPropertyName = "ContentVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType), TypeInfoPropertyName = "PlaceholderMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageRole), TypeInfoPropertyName = "PlaceholderMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Input), TypeInfoPropertyName = "Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestInputDiscriminatorType), TypeInfoPropertyName = "LogRequestInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Output), TypeInfoPropertyName = "Output2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestOutputDiscriminatorType), TypeInfoPropertyName = "LogRequestOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestStatus), TypeInfoPropertyName = "LogRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestErrorType), TypeInfoPropertyName = "LogRequestErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate5), TypeInfoPropertyName = "PromptTemplate52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanKind), TypeInfoPropertyName = "SpanKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StatusCode), TypeInfoPropertyName = "StatusCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Span))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSpansBulk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PromptLayer.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSpansBulkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSpansBulkResponseRejectionReason), TypeInfoPropertyName = "CreateSpansBulkResponseRejectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate6), TypeInfoPropertyName = "PromptTemplate62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>), TypeInfoPropertyName = "OneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem?), TypeInfoPropertyName = "NullableContentItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionPromptContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptTemplateFormat?), TypeInfoPropertyName = "NullableCompletionPromptTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CompletionPromptType?), TypeInfoPropertyName = "NullableCompletionPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextContentType?), TypeInfoPropertyName = "NullableTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>?), TypeInfoPropertyName = "NullableOneOfWebAnnotationFileAnnotationMapAnnotationContainerFileAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ThinkingContentType?), TypeInfoPropertyName = "NullableThinkingContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaFormat?), TypeInfoPropertyName = "NullableMediaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ImageContentType?), TypeInfoPropertyName = "NullableImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaContentType?), TypeInfoPropertyName = "NullableMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MediaVariableType?), TypeInfoPropertyName = "NullableMediaVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OutputMediaContentType?), TypeInfoPropertyName = "NullableOutputMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OutputMediaContentMediaType?), TypeInfoPropertyName = "NullableOutputMediaContentMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeContentType?), TypeInfoPropertyName = "NullableCodeContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ServerToolUseContentType?), TypeInfoPropertyName = "NullableServerToolUseContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchResultType?), TypeInfoPropertyName = "NullableWebSearchResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.WebSearchToolResultContentType?), TypeInfoPropertyName = "NullableWebSearchToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CodeExecutionResultContentType?), TypeInfoPropertyName = "NullableCodeExecutionResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpListToolsContentType?), TypeInfoPropertyName = "NullableMcpListToolsContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, object, object>?), TypeInfoPropertyName = "NullableAnyOfStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpCallContentType?), TypeInfoPropertyName = "NullableMcpCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalRequestContentType?), TypeInfoPropertyName = "NullableMcpApprovalRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.McpApprovalResponseContentType?), TypeInfoPropertyName = "NullableMcpApprovalResponseContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BashCodeExecutionToolResultContentType?), TypeInfoPropertyName = "NullableBashCodeExecutionToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContentType?), TypeInfoPropertyName = "NullableTextEditorCodeExecutionToolResultContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallContentType?), TypeInfoPropertyName = "NullableShellCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ShellCallOutputContentType?), TypeInfoPropertyName = "NullableShellCallOutputContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallContentType?), TypeInfoPropertyName = "NullableApplyPatchCallContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ApplyPatchCallOutputContentType?), TypeInfoPropertyName = "NullableApplyPatchCallOutputContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.BuiltInToolType?), TypeInfoPropertyName = "NullableBuiltInToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessageTemplateFormat?), TypeInfoPropertyName = "NullableSystemMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem2?), TypeInfoPropertyName = "NullableContentItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SystemMessageContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableSystemMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessageTemplateFormat?), TypeInfoPropertyName = "NullableUserMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem3?), TypeInfoPropertyName = "NullableContentItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.UserMessageContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableUserMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessageTemplateFormat?), TypeInfoPropertyName = "NullableAssistantMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item?), TypeInfoPropertyName = "NullableContentVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableAssistantMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessageTemplateFormat?), TypeInfoPropertyName = "NullableFunctionMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item2?), TypeInfoPropertyName = "NullableContentVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableFunctionMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessageTemplateFormat?), TypeInfoPropertyName = "NullableDeveloperMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem4?), TypeInfoPropertyName = "NullableContentItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableDeveloperMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.MessagesItem?), TypeInfoPropertyName = "NullableMessagesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPromptMessageDiscriminatorRole?), TypeInfoPropertyName = "NullableChatPromptMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Tool?), TypeInfoPropertyName = "NullableTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::PromptLayer.MessageFunctionCall, object>?), TypeInfoPropertyName = "NullableAnyOfStringMessageFunctionCallObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.AnyOf<string, global::PromptLayer.ChatToolChoice, object>?), TypeInfoPropertyName = "NullableAnyOfStringChatToolChoiceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ChatPromptType?), TypeInfoPropertyName = "NullableChatPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate?), TypeInfoPropertyName = "NullablePromptTemplate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate2?), TypeInfoPropertyName = "NullablePromptTemplate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate3?), TypeInfoPropertyName = "NullablePromptTemplate32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate4?), TypeInfoPropertyName = "NullablePromptTemplate42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessageTemplateFormat?), TypeInfoPropertyName = "NullableToolMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentItem5?), TypeInfoPropertyName = "NullableContentItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolMessageContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableToolMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ToolDiscriminatorType?), TypeInfoPropertyName = "NullableToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageTemplateFormat?), TypeInfoPropertyName = "NullablePlaceholderMessageTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.ContentVariant1Item3?), TypeInfoPropertyName = "NullableContentVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullablePlaceholderMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PlaceholderMessageRole?), TypeInfoPropertyName = "NullablePlaceholderMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Input?), TypeInfoPropertyName = "NullableInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestInputDiscriminatorType?), TypeInfoPropertyName = "NullableLogRequestInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.Output?), TypeInfoPropertyName = "NullableOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestOutputDiscriminatorType?), TypeInfoPropertyName = "NullableLogRequestOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestStatus?), TypeInfoPropertyName = "NullableLogRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.LogRequestErrorType?), TypeInfoPropertyName = "NullableLogRequestErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate5?), TypeInfoPropertyName = "NullablePromptTemplate52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.SpanKind?), TypeInfoPropertyName = "NullableSpanKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.StatusCode?), TypeInfoPropertyName = "NullableStatusCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.CreateSpansBulkResponseRejectionReason?), TypeInfoPropertyName = "NullableCreateSpansBulkResponseRejectionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.PromptTemplate6?), TypeInfoPropertyName = "NullablePromptTemplate62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>?), TypeInfoPropertyName = "NullableOneOfHTTPValidationErrorErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.WebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PromptLayer.Span>))]
    internal sealed partial class SpansSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpansSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SpansSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SpansSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItemJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItem2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItem3JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentVariant1ItemJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentVariant1Item2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItem4JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.MessagesItemJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplateJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate2JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate3JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate4JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentItem5JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.ContentVariant1Item3JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.InputJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OutputJsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate5JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.PromptTemplate6JsonConverter());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.MessageFunctionCall, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::PromptLayer.ChatToolChoice, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<string, double?, bool?, byte[], object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.OneOfJsonConverter<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>());
            options.Converters.Add(new global::PromptLayer.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::PromptLayer.CompletionPromptContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.CompletionPromptContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.CompletionPromptTemplateFormat)

                    || typeToConvert == typeof(global::PromptLayer.CompletionPromptTemplateFormat?)

                    || typeToConvert == typeof(global::PromptLayer.CompletionPromptType)

                    || typeToConvert == typeof(global::PromptLayer.CompletionPromptType?)

                    || typeToConvert == typeof(global::PromptLayer.TextContentType)

                    || typeToConvert == typeof(global::PromptLayer.TextContentType?)

                    || typeToConvert == typeof(global::PromptLayer.ThinkingContentType)

                    || typeToConvert == typeof(global::PromptLayer.ThinkingContentType?)

                    || typeToConvert == typeof(global::PromptLayer.MediaFormat)

                    || typeToConvert == typeof(global::PromptLayer.MediaFormat?)

                    || typeToConvert == typeof(global::PromptLayer.ImageContentType)

                    || typeToConvert == typeof(global::PromptLayer.ImageContentType?)

                    || typeToConvert == typeof(global::PromptLayer.MediaContentType)

                    || typeToConvert == typeof(global::PromptLayer.MediaContentType?)

                    || typeToConvert == typeof(global::PromptLayer.MediaVariableType)

                    || typeToConvert == typeof(global::PromptLayer.MediaVariableType?)

                    || typeToConvert == typeof(global::PromptLayer.OutputMediaContentType)

                    || typeToConvert == typeof(global::PromptLayer.OutputMediaContentType?)

                    || typeToConvert == typeof(global::PromptLayer.OutputMediaContentMediaType)

                    || typeToConvert == typeof(global::PromptLayer.OutputMediaContentMediaType?)

                    || typeToConvert == typeof(global::PromptLayer.CodeContentType)

                    || typeToConvert == typeof(global::PromptLayer.CodeContentType?)

                    || typeToConvert == typeof(global::PromptLayer.ServerToolUseContentType)

                    || typeToConvert == typeof(global::PromptLayer.ServerToolUseContentType?)

                    || typeToConvert == typeof(global::PromptLayer.WebSearchResultType)

                    || typeToConvert == typeof(global::PromptLayer.WebSearchResultType?)

                    || typeToConvert == typeof(global::PromptLayer.WebSearchToolResultContentType)

                    || typeToConvert == typeof(global::PromptLayer.WebSearchToolResultContentType?)

                    || typeToConvert == typeof(global::PromptLayer.CodeExecutionResultContentType)

                    || typeToConvert == typeof(global::PromptLayer.CodeExecutionResultContentType?)

                    || typeToConvert == typeof(global::PromptLayer.McpListToolsContentType)

                    || typeToConvert == typeof(global::PromptLayer.McpListToolsContentType?)

                    || typeToConvert == typeof(global::PromptLayer.McpCallContentType)

                    || typeToConvert == typeof(global::PromptLayer.McpCallContentType?)

                    || typeToConvert == typeof(global::PromptLayer.McpApprovalRequestContentType)

                    || typeToConvert == typeof(global::PromptLayer.McpApprovalRequestContentType?)

                    || typeToConvert == typeof(global::PromptLayer.McpApprovalResponseContentType)

                    || typeToConvert == typeof(global::PromptLayer.McpApprovalResponseContentType?)

                    || typeToConvert == typeof(global::PromptLayer.BashCodeExecutionToolResultContentType)

                    || typeToConvert == typeof(global::PromptLayer.BashCodeExecutionToolResultContentType?)

                    || typeToConvert == typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContentType)

                    || typeToConvert == typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContentType?)

                    || typeToConvert == typeof(global::PromptLayer.ShellCallContentType)

                    || typeToConvert == typeof(global::PromptLayer.ShellCallContentType?)

                    || typeToConvert == typeof(global::PromptLayer.ShellCallOutputContentType)

                    || typeToConvert == typeof(global::PromptLayer.ShellCallOutputContentType?)

                    || typeToConvert == typeof(global::PromptLayer.ApplyPatchCallContentType)

                    || typeToConvert == typeof(global::PromptLayer.ApplyPatchCallContentType?)

                    || typeToConvert == typeof(global::PromptLayer.ApplyPatchCallOutputContentType)

                    || typeToConvert == typeof(global::PromptLayer.ApplyPatchCallOutputContentType?)

                    || typeToConvert == typeof(global::PromptLayer.BuiltInToolType)

                    || typeToConvert == typeof(global::PromptLayer.BuiltInToolType?)

                    || typeToConvert == typeof(global::PromptLayer.SystemMessageTemplateFormat)

                    || typeToConvert == typeof(global::PromptLayer.SystemMessageTemplateFormat?)

                    || typeToConvert == typeof(global::PromptLayer.SystemMessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.SystemMessageContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.UserMessageTemplateFormat)

                    || typeToConvert == typeof(global::PromptLayer.UserMessageTemplateFormat?)

                    || typeToConvert == typeof(global::PromptLayer.UserMessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.UserMessageContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.AssistantMessageTemplateFormat)

                    || typeToConvert == typeof(global::PromptLayer.AssistantMessageTemplateFormat?)

                    || typeToConvert == typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.FunctionMessageTemplateFormat)

                    || typeToConvert == typeof(global::PromptLayer.FunctionMessageTemplateFormat?)

                    || typeToConvert == typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.DeveloperMessageTemplateFormat)

                    || typeToConvert == typeof(global::PromptLayer.DeveloperMessageTemplateFormat?)

                    || typeToConvert == typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.ChatPromptMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::PromptLayer.ChatPromptMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::PromptLayer.ChatPromptType)

                    || typeToConvert == typeof(global::PromptLayer.ChatPromptType?)

                    || typeToConvert == typeof(global::PromptLayer.ToolMessageTemplateFormat)

                    || typeToConvert == typeof(global::PromptLayer.ToolMessageTemplateFormat?)

                    || typeToConvert == typeof(global::PromptLayer.ToolMessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.ToolMessageContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.ToolDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.ToolDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.PlaceholderMessageTemplateFormat)

                    || typeToConvert == typeof(global::PromptLayer.PlaceholderMessageTemplateFormat?)

                    || typeToConvert == typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.PlaceholderMessageRole)

                    || typeToConvert == typeof(global::PromptLayer.PlaceholderMessageRole?)

                    || typeToConvert == typeof(global::PromptLayer.LogRequestInputDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.LogRequestInputDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.LogRequestOutputDiscriminatorType)

                    || typeToConvert == typeof(global::PromptLayer.LogRequestOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::PromptLayer.LogRequestStatus)

                    || typeToConvert == typeof(global::PromptLayer.LogRequestStatus?)

                    || typeToConvert == typeof(global::PromptLayer.LogRequestErrorType)

                    || typeToConvert == typeof(global::PromptLayer.LogRequestErrorType?)

                    || typeToConvert == typeof(global::PromptLayer.SpanKind)

                    || typeToConvert == typeof(global::PromptLayer.SpanKind?)

                    || typeToConvert == typeof(global::PromptLayer.StatusCode)

                    || typeToConvert == typeof(global::PromptLayer.StatusCode?)

                    || typeToConvert == typeof(global::PromptLayer.CreateSpansBulkResponseRejectionReason)

                    || typeToConvert == typeof(global::PromptLayer.CreateSpansBulkResponseRejectionReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::PromptLayer.CompletionPromptContentItemDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.CompletionPromptContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CompletionPromptContentItemDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.CompletionPromptContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CompletionPromptTemplateFormat))
                {
                    return new global::PromptLayer.JsonConverters.CompletionPromptTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CompletionPromptTemplateFormat?))
                {
                    return new global::PromptLayer.JsonConverters.CompletionPromptTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CompletionPromptType))
                {
                    return new global::PromptLayer.JsonConverters.CompletionPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CompletionPromptType?))
                {
                    return new global::PromptLayer.JsonConverters.CompletionPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TextContentType))
                {
                    return new global::PromptLayer.JsonConverters.TextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TextContentType?))
                {
                    return new global::PromptLayer.JsonConverters.TextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ThinkingContentType))
                {
                    return new global::PromptLayer.JsonConverters.ThinkingContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ThinkingContentType?))
                {
                    return new global::PromptLayer.JsonConverters.ThinkingContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.MediaFormat))
                {
                    return new global::PromptLayer.JsonConverters.MediaFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.MediaFormat?))
                {
                    return new global::PromptLayer.JsonConverters.MediaFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ImageContentType))
                {
                    return new global::PromptLayer.JsonConverters.ImageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ImageContentType?))
                {
                    return new global::PromptLayer.JsonConverters.ImageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.MediaContentType))
                {
                    return new global::PromptLayer.JsonConverters.MediaContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.MediaContentType?))
                {
                    return new global::PromptLayer.JsonConverters.MediaContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.MediaVariableType))
                {
                    return new global::PromptLayer.JsonConverters.MediaVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.MediaVariableType?))
                {
                    return new global::PromptLayer.JsonConverters.MediaVariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.OutputMediaContentType))
                {
                    return new global::PromptLayer.JsonConverters.OutputMediaContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.OutputMediaContentType?))
                {
                    return new global::PromptLayer.JsonConverters.OutputMediaContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.OutputMediaContentMediaType))
                {
                    return new global::PromptLayer.JsonConverters.OutputMediaContentMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.OutputMediaContentMediaType?))
                {
                    return new global::PromptLayer.JsonConverters.OutputMediaContentMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CodeContentType))
                {
                    return new global::PromptLayer.JsonConverters.CodeContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CodeContentType?))
                {
                    return new global::PromptLayer.JsonConverters.CodeContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ServerToolUseContentType))
                {
                    return new global::PromptLayer.JsonConverters.ServerToolUseContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ServerToolUseContentType?))
                {
                    return new global::PromptLayer.JsonConverters.ServerToolUseContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.WebSearchResultType))
                {
                    return new global::PromptLayer.JsonConverters.WebSearchResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.WebSearchResultType?))
                {
                    return new global::PromptLayer.JsonConverters.WebSearchResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.WebSearchToolResultContentType))
                {
                    return new global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.WebSearchToolResultContentType?))
                {
                    return new global::PromptLayer.JsonConverters.WebSearchToolResultContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CodeExecutionResultContentType))
                {
                    return new global::PromptLayer.JsonConverters.CodeExecutionResultContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CodeExecutionResultContentType?))
                {
                    return new global::PromptLayer.JsonConverters.CodeExecutionResultContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.McpListToolsContentType))
                {
                    return new global::PromptLayer.JsonConverters.McpListToolsContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.McpListToolsContentType?))
                {
                    return new global::PromptLayer.JsonConverters.McpListToolsContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.McpCallContentType))
                {
                    return new global::PromptLayer.JsonConverters.McpCallContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.McpCallContentType?))
                {
                    return new global::PromptLayer.JsonConverters.McpCallContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.McpApprovalRequestContentType))
                {
                    return new global::PromptLayer.JsonConverters.McpApprovalRequestContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.McpApprovalRequestContentType?))
                {
                    return new global::PromptLayer.JsonConverters.McpApprovalRequestContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.McpApprovalResponseContentType))
                {
                    return new global::PromptLayer.JsonConverters.McpApprovalResponseContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.McpApprovalResponseContentType?))
                {
                    return new global::PromptLayer.JsonConverters.McpApprovalResponseContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.BashCodeExecutionToolResultContentType))
                {
                    return new global::PromptLayer.JsonConverters.BashCodeExecutionToolResultContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.BashCodeExecutionToolResultContentType?))
                {
                    return new global::PromptLayer.JsonConverters.BashCodeExecutionToolResultContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContentType))
                {
                    return new global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.TextEditorCodeExecutionToolResultContentType?))
                {
                    return new global::PromptLayer.JsonConverters.TextEditorCodeExecutionToolResultContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ShellCallContentType))
                {
                    return new global::PromptLayer.JsonConverters.ShellCallContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ShellCallContentType?))
                {
                    return new global::PromptLayer.JsonConverters.ShellCallContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ShellCallOutputContentType))
                {
                    return new global::PromptLayer.JsonConverters.ShellCallOutputContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ShellCallOutputContentType?))
                {
                    return new global::PromptLayer.JsonConverters.ShellCallOutputContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ApplyPatchCallContentType))
                {
                    return new global::PromptLayer.JsonConverters.ApplyPatchCallContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ApplyPatchCallContentType?))
                {
                    return new global::PromptLayer.JsonConverters.ApplyPatchCallContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ApplyPatchCallOutputContentType))
                {
                    return new global::PromptLayer.JsonConverters.ApplyPatchCallOutputContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ApplyPatchCallOutputContentType?))
                {
                    return new global::PromptLayer.JsonConverters.ApplyPatchCallOutputContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.BuiltInToolType))
                {
                    return new global::PromptLayer.JsonConverters.BuiltInToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.BuiltInToolType?))
                {
                    return new global::PromptLayer.JsonConverters.BuiltInToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.SystemMessageTemplateFormat))
                {
                    return new global::PromptLayer.JsonConverters.SystemMessageTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.SystemMessageTemplateFormat?))
                {
                    return new global::PromptLayer.JsonConverters.SystemMessageTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.SystemMessageContentItemDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.SystemMessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.SystemMessageContentItemDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.SystemMessageContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.UserMessageTemplateFormat))
                {
                    return new global::PromptLayer.JsonConverters.UserMessageTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.UserMessageTemplateFormat?))
                {
                    return new global::PromptLayer.JsonConverters.UserMessageTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.UserMessageContentItemDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.UserMessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.UserMessageContentItemDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.UserMessageContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.AssistantMessageTemplateFormat))
                {
                    return new global::PromptLayer.JsonConverters.AssistantMessageTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.AssistantMessageTemplateFormat?))
                {
                    return new global::PromptLayer.JsonConverters.AssistantMessageTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.FunctionMessageTemplateFormat))
                {
                    return new global::PromptLayer.JsonConverters.FunctionMessageTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.FunctionMessageTemplateFormat?))
                {
                    return new global::PromptLayer.JsonConverters.FunctionMessageTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DeveloperMessageTemplateFormat))
                {
                    return new global::PromptLayer.JsonConverters.DeveloperMessageTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DeveloperMessageTemplateFormat?))
                {
                    return new global::PromptLayer.JsonConverters.DeveloperMessageTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.DeveloperMessageContentItemDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ChatPromptMessageDiscriminatorRole))
                {
                    return new global::PromptLayer.JsonConverters.ChatPromptMessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ChatPromptMessageDiscriminatorRole?))
                {
                    return new global::PromptLayer.JsonConverters.ChatPromptMessageDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ChatPromptType))
                {
                    return new global::PromptLayer.JsonConverters.ChatPromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ChatPromptType?))
                {
                    return new global::PromptLayer.JsonConverters.ChatPromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ToolMessageTemplateFormat))
                {
                    return new global::PromptLayer.JsonConverters.ToolMessageTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ToolMessageTemplateFormat?))
                {
                    return new global::PromptLayer.JsonConverters.ToolMessageTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ToolMessageContentItemDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.ToolMessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ToolMessageContentItemDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.ToolMessageContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ToolDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.ToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.ToolDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.PlaceholderMessageTemplateFormat))
                {
                    return new global::PromptLayer.JsonConverters.PlaceholderMessageTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.PlaceholderMessageTemplateFormat?))
                {
                    return new global::PromptLayer.JsonConverters.PlaceholderMessageTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.PlaceholderMessageRole))
                {
                    return new global::PromptLayer.JsonConverters.PlaceholderMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.PlaceholderMessageRole?))
                {
                    return new global::PromptLayer.JsonConverters.PlaceholderMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.LogRequestInputDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.LogRequestInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.LogRequestInputDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.LogRequestInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.LogRequestOutputDiscriminatorType))
                {
                    return new global::PromptLayer.JsonConverters.LogRequestOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.LogRequestOutputDiscriminatorType?))
                {
                    return new global::PromptLayer.JsonConverters.LogRequestOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.LogRequestStatus))
                {
                    return new global::PromptLayer.JsonConverters.LogRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.LogRequestStatus?))
                {
                    return new global::PromptLayer.JsonConverters.LogRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.LogRequestErrorType))
                {
                    return new global::PromptLayer.JsonConverters.LogRequestErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.LogRequestErrorType?))
                {
                    return new global::PromptLayer.JsonConverters.LogRequestErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.SpanKind))
                {
                    return new global::PromptLayer.JsonConverters.SpanKindJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.SpanKind?))
                {
                    return new global::PromptLayer.JsonConverters.SpanKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.StatusCode))
                {
                    return new global::PromptLayer.JsonConverters.StatusCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.StatusCode?))
                {
                    return new global::PromptLayer.JsonConverters.StatusCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateSpansBulkResponseRejectionReason))
                {
                    return new global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::PromptLayer.CreateSpansBulkResponseRejectionReason?))
                {
                    return new global::PromptLayer.JsonConverters.CreateSpansBulkResponseRejectionReasonNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SpansSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}