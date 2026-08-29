
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Evaluation? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.EvaluationRun>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationRun? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationRunStatus? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationRunStats? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ExternalId>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExternalId? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetSnippetUsageResponse? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetSnippetUsageResponseLabelUsageItem>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetSnippetUsageResponseLabelUsageItem? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RunWorkflow? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RunWorkflowResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.WorkflowNode? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EdgeConditional? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EdgeConditionalOperator? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Edge? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.EdgeConditional>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateWorkflow? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.WorkflowNode>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Edge>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.NodeUpdate? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PatchWorkflow? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateWorkflowResponse? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateWorkflowResponseNode>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateWorkflowResponseNode? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ErrorResponse? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SkillCollectionErrorResponse? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SkillCollection? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SkillCollectionVersion? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.InitialFileUpdate? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FileUpdate? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FileMove? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateSkillCollectionRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.InitialFileUpdate>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateSkillCollectionMultipartRequest? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateSkillCollectionRequest? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SaveSkillCollectionVersionRequest? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.FileUpdate>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.FileMove>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SaveSkillCollectionVersionMultipartRequest? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListSkillCollectionsResponse? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.SkillCollection>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetSkillCollectionResponse? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateSkillCollectionResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateSkillCollectionResponse? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SaveSkillCollectionVersionResponse? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Base? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Function? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FunctionCall? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.HTTPValidationError? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ValidationError>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ValidationError? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.AnyOf<string, int?>>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<string, int?>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Model? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Metadata? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplate? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateProvider2? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CompletionPrompt? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContentItem? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TextContent? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ThinkingContent? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CodeContent? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ImageContent? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MediaContent? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MediaVariable? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OutputMediaContent? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ServerToolUseContent? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.WebSearchToolResultContent? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CodeExecutionResultContent? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpListToolsContent? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpCallContent? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpApprovalRequestContent? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpApprovalResponseContent? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.BashCodeExecutionToolResultContent? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TextEditorCodeExecutionToolResultContent? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ShellCallContent? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ShellCallOutputContent? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ApplyPatchCallContent? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ApplyPatchCallOutputContent? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CompletionPromptContentItemDiscriminator? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CompletionPromptContentItemDiscriminatorType? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CompletionPromptTemplateFormat? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CompletionPromptType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FileAnnotation? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.WebAnnotation? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MapAnnotation? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContainerFileAnnotation? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TextContentType? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ThinkingContentType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ImageURL? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Media? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MediaFormat? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ImageContentType? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MediaContentType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MediaVariableType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OutputMediaContentType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OutputMediaContentMediaType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CodeContentType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ServerToolUseContentType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.WebSearchResult? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.WebSearchResultType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.WebSearchToolResultContentType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.WebSearchResult>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CodeExecutionResultContentType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpListToolsContentType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<string, object, object>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpCallContentType? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpApprovalRequestContentType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.McpApprovalResponseContentType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.BashCodeExecutionToolResultContentType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TextEditorCodeExecutionToolResultContentType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ShellCallContentType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ShellCallOutputContentType? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ApplyPatchCallContentType? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ApplyPatchCallOutputContentType? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.BuiltInTool? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.BuiltInToolType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SystemMessage? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SystemMessageTemplateFormat? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem2>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContentItem2? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SystemMessageContentItemDiscriminator? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SystemMessageContentItemDiscriminatorType? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UserMessage? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UserMessageTemplateFormat? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem3>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContentItem3? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UserMessageContentItemDiscriminator? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UserMessageContentItemDiscriminatorType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AssistantMessage? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AssistantMessageTemplateFormat? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContentVariant1Item? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminator? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ToolCall>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ToolCall? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FunctionMessage? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FunctionMessageTemplateFormat? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item2>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContentVariant1Item2? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminator? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeveloperMessage? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeveloperMessageTemplateFormat? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem4>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContentItem4? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeveloperMessageContentItemDiscriminator? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeveloperMessageContentItemDiscriminatorType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MessageFunctionCall? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ChatPrompt? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.MessagesItem>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MessagesItem? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ToolMessage? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PlaceholderMessage? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ChatPromptMessageDiscriminator? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ChatPromptMessageDiscriminatorRole? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Function>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Tool>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Tool? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::PromptLayer.MessageFunctionCall, object>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::PromptLayer.ChatToolChoice, object>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ChatToolChoice? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ChatPromptType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptTemplate? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminator? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SnippetReference? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateRawResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptTemplate2? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateRawResponsePromptTemplateDiscriminator? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateRawResponsePromptTemplateDiscriminatorType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.SnippetReference>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateLabelResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.BasePromptTemplate? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptVersion? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptTemplate3? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptVersionPromptTemplateDiscriminator? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptVersionPromptTemplateDiscriminatorType? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PatchPromptTemplateVersion? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreatePromptTemplate? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreatePromptTemplateResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptTemplate4? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreatePromptTemplateResponsePromptTemplateDiscriminator? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreatePromptTemplateResponsePromptTemplateDiscriminatorType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ToolMessageTemplateFormat? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem5>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContentItem5? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ToolMessageContentItemDiscriminator? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ToolMessageContentItemDiscriminatorType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FunctionTool? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ToolDiscriminator? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ToolDiscriminatorType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListPromptTemplates? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListPromptTemplateItem>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListPromptTemplateItem? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PlaceholderMessageTemplateFormat? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item3>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ContentVariant1Item3? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminator? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PlaceholderMessageRole? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequest? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Input? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequestInputDiscriminator? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequestInputDiscriminatorType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Output? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequestOutputDiscriminator? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequestOutputDiscriminatorType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequestStatus? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequestErrorType2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequestResponse? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.LogRequestResponseStatus? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.BadRequestError? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptBlueprint? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptTemplate5? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptBlueprintPromptTemplateDiscriminator? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptBlueprintPromptTemplateDiscriminatorType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SpanKind? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.StatusCode? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SpanContext? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SpanStatus? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SpanResource? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Span? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateSpansBulk? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Span>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateSpansBulkResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateSpansBulkResponseRejectionReason? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Dataset? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DatasetGroup? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateFolderRequest? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateFolderSuccessResponse? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Folder? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FolderExistsError? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ParentFolderNotFoundError? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UnauthorizedError? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FolderNotFoundError? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateFolderRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EntityType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FolderEntity? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptEntityMetadata? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.WorkflowEntityMetadata? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DatasetEntityMetadata? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptEntityMetadataType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.FolderEntity>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EntityReference? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MoveFolderEntitiesRequest? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.EntityReference>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteFolderEntitiesRequest? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FolderEntitiesCountResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ResolveFolderIdResponse? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanResource? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpKeyValue>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpKeyValue? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpanScope? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpan>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpSpan? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpSpanStatus? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpanEvent>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpSpanEvent? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpanLink>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpSpanLink? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpKeyValueValue? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpKeyValueValueArrayValue? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceResponse? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceResponsePartialSuccess? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestLogQuery? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.StructuredFilterGroup? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestLogQuerySortBy? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestLogQuerySortOrder? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsLatencyByDay? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsDimensionLatency? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsStat? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsStatOutputShapeCounts? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsBreakdownEntry? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsToolLatency? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsResponseChartInterval? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsStat>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMostUsedPromptTemplate>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsResponseMostUsedPromptTemplate? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.RequestAnalyticsDimensionLatency>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseErrorType>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsResponseErrorType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsBreakdownEntry>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMetadataKeysTopItem>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsResponseMetadataKeysTopItem? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseOutputKeysTopItem>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsResponseOutputKeysTopItem? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsToolLatency>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseToolsUsageBar>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsResponseToolsUsageBar? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestAnalyticsResponseMetadataValueBreakdownItem>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsResponseMetadataValueBreakdownItem? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SearchRequestLogsRequest? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SearchRequestLogsRequestVariant2? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.StructuredFilter? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.StructuredFilterField? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.StructuredFilterOperator? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<string, double?, bool?, byte[], object>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.StructuredFilterGroupLogic? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SearchRequestLogsResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.RequestLogSearchResult>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestLogSearchResult? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AttachExternalIdRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExternalIdAttachResponse? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExternalIdsListResponse? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExternalIdDeleteResponse? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExternalIdErrorResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptTemplate6? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminator? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListPromptTemplateItemPromptTemplateDiscriminatorType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RateLimitError? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationColumnDefinition? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationColumnDefinitionColumnType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ScoreConfiguration? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ScoreConfigurationCodeLanguage? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationPipelineSummary? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ReportColumnSummary? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ReportColumnSummaryColumnType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.EvaluationColumnDefinition>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ReportColumnSummary>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateReportScoreCardRequest? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateReportScoreCardRequestCodeLanguage? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateReportScoreCardResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EditReportColumnRequest? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EditReportColumnRequestColumnType? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EditReportColumnResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RenameReportRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RenameReportResponse? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteReportResponse? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDatasetGroupRequest? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDatasetGroupResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<global::PromptLayer.DatasetGroup, object>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<global::PromptLayer.Dataset, object>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DatasetRowCell? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DatasetRowCellType? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationRowCell? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationRowCellType? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DatasetRowsResponse? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.DatasetRowCell>>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.DatasetRowCell>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EvaluationRowsResponse? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestLogDetailResponse? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceDetailResponse? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SearchRequestSuggestionsResponse? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TrackPromptRequest? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<int?, string>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<int?, string, object>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TrackMetadataRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TrackResponse? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFileRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFileResponse? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateDraftDatasetVersionRequest? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DraftDatasetVersionResponse? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddRequestLogToDatasetRequest? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SaveDraftDatasetVersionRequest? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddTraceToDatasetRequest? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddTraceToDatasetResponse? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddTraceToDatasetResponseMode? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Table? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableDetail? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Sheet? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableColumnType? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Column? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.Cell? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CellStatus? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.SmartTableRequestMetrics? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableImportOperation? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableImportOperationSource? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableImportOperationStatus? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExecutionMetadataMetricAggregate? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExecutionMetadataMetricAggregateMetricKey? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExecutionMetadataAggregates? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.ExecutionMetadataMetricAggregate>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ExecutionMetadataAggregatesSheet? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetOperationsResponse? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TableSheetOperation>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetOperation? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableRequest? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableResponse? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationRequest? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationRequestOperation? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetOperationRequestStatuse>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationRequestStatuse? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationResponse? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationQueuedResponse? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationNoopResponse? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationConfirmationResponse? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetOperationResponse? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CancelTableSheetOperationResponse? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreResponse? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreResponseScoringType? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScoreColumn>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreColumn? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?>>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreCellObject? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScoreMetric>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreMetric? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreResponseStatus? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreConfiguration? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreResponseScoreType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ConfigureTableSheetScoreRequest? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ConfigureTableSheetScoreRequestScoreType? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ConfigureTableSheetScoreRequestCodeLanguage? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ConfigureTableSheetScoreRequestAssertionAggregation? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ConfigureTableSheetScoreResponse? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RecalculateTableSheetScoreResponse? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RecalculateTableSheetScoreResponseStatus? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardStaleState? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardAggregation? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardAggregationRequiredStepFailureBehavior? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardStep? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardStepPrimitiveType? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardStepEvidenceMode? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecard? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardStatus? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardStep>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardCalculation? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardCalculationStatus? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardCalculationAggregateVerdict? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardGetResponse? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardGetResponseProgress? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ConfigureTableSheetScorecardRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ConfigureTableSheetScorecardResponse? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteTableSheetScorecardResponse? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MigrateLegacyTableSheetScoreRequest? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MigrateLegacyTableSheetScoreResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.MigrateLegacyTableSheetScoreResponseSkippedItem>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.MigrateLegacyTableSheetScoreResponseSkippedItem? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RecalculateTableSheetScorecardRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RecalculateTableSheetScorecardResponse? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RecalculateTableSheetScorecardResponseStatus? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CancelTableSheetScorecardRequest? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CancelTableSheetScorecardResponse? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CancelTableSheetScorecardResponseScorecard? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetScorecardCalculationResponse? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardRowSummary? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScorecardRowSummaryAggregateVerdict? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetScorecardRowsResponse? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TableSheetScorecardRowSummary>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetScorecardRowResponse? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetScorecardRowResponseAggregateVerdict? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetVersionsResponse? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TableSheetVersion>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetVersion? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PublicListPagination? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.EmptyPublicFilters? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetVersionRequest? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetVersionResponse? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreHistoryResponse? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreHistoryResponseScoreHistory? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreHistoryResponseScoreHistoryResolution? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetFileImportRequest? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetImportStartResponse? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetRequestLogImportRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetRequestLogImportRequestSortBy? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetRequestLogImportRequestSortOrder? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetOperationOperation? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationQueuedResponseOperation? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TableCell>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableCell? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreColumnResolvedScoringType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableSheetScoreConfigurationScoreType? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TableCellStatus? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DerivedRatioInsightSpec? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DerivedRatioInsightSpecType? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DerivedRatioInsightResult? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DerivedRatioInsightResultType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSpec? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSpecChartType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSpecMetric? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSpecMetricField? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSeriesSpec>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSeriesSpec? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.DerivedRatioInsightSpec>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSpecGroupByField? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSeriesSpecMetric? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSeriesSpecMetricField? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSeriesMeta? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsSeriesMetaUnit? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsResult? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CustomAnalyticsResultChartType? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSeriesMeta>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.DerivedRatioInsightResult>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsCustomAnalyticsQuery? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortBy? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsCustomAnalyticsQuerySortOrder? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsSpec>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RequestAnalyticsCustomAnalyticsResponse? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CustomAnalyticsResult>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceStructuredFilter? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceStructuredFilterGroup? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceStructuredFilterGroupLogic? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpec? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecChartType? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecMetric? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecMetricField? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecGroupByField? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecSecondaryGroupByField? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecHistogramField? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpecHierarchyField>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecHierarchyField? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecTimeBucket? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpecSerie>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecSerie? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecSerieMetric? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceCustomChartSpecSerieMetricField? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TraceAnalyticsCustomAnalyticsQuery? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.TraceCustomChartSpec>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreatePromptLabelRequest? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchRequest? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TrackGroupRequest? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TrackScoreRequest? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddReportColumnRequest? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddReportColumnRequestColumnType? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RunReportRequest? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolRegistryRequest? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolRegistryRequestExecution? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolRegistryRequestExecutionType? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolRegistryRequestExecutionLanguage? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableRequest? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetRequest? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.CreateTableSheetRequestSourceFileSource, global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetRequestSourceFileSource? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetRequestSourceFileSourceType? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSource? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetRequestSourceRequestLogsSourceType? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableSheetRequest? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetColumnRequest? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateTableSheetColumnRequestDependencie>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetColumnRequestDependencie? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableSheetColumnRequest? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableSheetColumnRequestDependencie? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddTableSheetRowsRequest? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableSheetCellRequest? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetCellRecalculationsBatchRequest? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolVersionRequest? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolVersionRequestExecution? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolVersionRequestExecutionType? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolVersionRequestExecutionLanguage? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TestExecuteToolRequest? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TestExecuteToolRequestExecution? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TestExecuteToolRequestExecutionType? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TestExecuteToolRequestExecutionLanguage? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateWorkspaceEnvVarRequest? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateWorkspaceEnvVarRequest? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolEnvVarRequest? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateToolEnvVarRequest? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListDatasetsStatus? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListDatasetsSortBy? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListDatasetsSortOrder? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListEvaluationsStatus? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListEvaluationsSortBy? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListEvaluationsSortOrder? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetAllPromptTemplatesGetStatus? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetAllPromptTemplatesGetSortBy? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetAllPromptTemplatesGetSortOrder? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListWorkflowsSortBy? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListWorkflowsSortOrder? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortBy? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetSortOrder? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<string, global::System.Collections.Generic.IList<string>>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.IngestOtlpTracesContentType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.IngestOtlpTracesContentEncoding? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListSkillCollectionsPublicSortBy? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListSkillCollectionsPublicSortOrder? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetSkillCollectionPublicFormat? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetRequestSearchSuggestionsField? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListToolRegistriesSortBy? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListToolRegistriesSortOrder? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTablesOrder? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetsOrder? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetRowsOrder? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetScorecardRowsVerdict? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetVersionsSort? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetVersionsOrder? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetVersionScoreHistoryRange? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetVersionScoreHistoryResolution? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.HTTPValidationError, global::PromptLayer.ErrorResponse>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreatePromptLabelResponse? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchResponse? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TrackGroupResponse? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TrackScoreResponse? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteReportsByNameResponse? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse2? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse2? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse3? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse4? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RunReportResponse? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RunReportResponse2? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RunReportResponse3? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RunReportResponse4? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.RunReportResponse5? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportResponse? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportResponseReport? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportResponseStatus? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportResponseStats? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportResponseStatsStatusCounts? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetReportResponseReportColumn>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportResponseReportColumn? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportScoreResponse? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScore? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreScoreType? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListDatasetsResponse? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Dataset>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListEvaluationsResponse? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Evaluation>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListWorkflowsResponseItem>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponseItem? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse2? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse3? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetWorkflowResponse? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowResponseNode>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetWorkflowResponseNode? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowResponseEdge>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetWorkflowResponseEdge? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetWorkflowLabelsResponse? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<global::PromptLayer.FolderExistsError, string>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.IngestOtlpTracesResponse2? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListToolRegistriesResponse? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListToolRegistriesResponseToolRegistrie>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListToolRegistriesResponseToolRegistrie? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolRegistryResponse? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetToolRegistryResponse? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetToolRegistryResponseToolRegistry? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTablesResponse? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Table>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableResponse? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableResponse? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteTableResponse? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetsResponse? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Sheet>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetResponse? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetResponse2? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetOperationResponse2? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetResponse? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableSheetResponse? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteTableSheetResponse? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetColumnsResponse? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Column>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetColumnResponse? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Cell>? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableSheetColumnResponse? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteTableSheetColumnResponse? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetRowsResponse? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListTableSheetRowsResponseDataItem>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListTableSheetRowsResponseDataItem? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.Cell>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddTableSheetRowsResponse? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.AddTableSheetRowsResponseRow>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AddTableSheetRowsResponseRow? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.GetTableSheetCellResponse? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateTableSheetCellResponse? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetCellRecalculationsBatchResponse? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetCellRecalculationResponse? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolVersionResponse? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TestExecuteToolResponse? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TestExecuteToolResponseResult? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.TestExecuteToolResponseResultStatus? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CloseTraceResponse? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CloseTraceResponseClosure? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CloseTraceResponseClosureStatus? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CloseTraceResponse2? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListWorkspaceEnvVarsResponse? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListWorkspaceEnvVarsResponseWorkspaceEnvVar>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListWorkspaceEnvVarsResponseWorkspaceEnvVar? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateWorkspaceEnvVarResponse? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateWorkspaceEnvVarResponseWorkspaceEnvVar? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateWorkspaceEnvVarResponse2? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateWorkspaceEnvVarResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateWorkspaceEnvVarResponseWorkspaceEnvVar? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateWorkspaceEnvVarResponse2? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteWorkspaceEnvVarResponse? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteWorkspaceEnvVarResponse2? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListToolEnvVarsResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListToolEnvVarsResponseToolEnvVar>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListToolEnvVarsResponseToolEnvVar? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ListToolEnvVarsResponse2? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolEnvVarResponse? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolEnvVarResponseToolEnvVar? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolEnvVarResponse2? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateToolEnvVarResponse3? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateToolEnvVarResponse? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateToolEnvVarResponseToolEnvVar? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.UpdateToolEnvVarResponse2? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteToolEnvVarResponse? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.DeleteToolEnvVarResponse2? Type759 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.EvaluationRun>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ExternalId>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetSnippetUsageResponseLabelUsageItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.EdgeConditional>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.WorkflowNode>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Edge>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateWorkflowResponseNode>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.InitialFileUpdate>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.FileUpdate>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.FileMove>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.SkillCollection>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ValidationError>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.WebSearchResult>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem2>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem3>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ToolCall>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item2>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem4>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.MessagesItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Function>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Tool>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.SnippetReference>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.List<object>, object>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem5>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListPromptTemplateItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item3>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Span>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.FolderEntity>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.EntityReference>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpKeyValue>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpan>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpanEvent>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpanLink>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsStat>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseMostUsedPromptTemplate>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseErrorType>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsBreakdownEntry>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseMetadataKeysTopItem>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseOutputKeysTopItem>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsToolLatency>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseToolsUsageBar>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestAnalyticsResponseMetadataValueBreakdownItem>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.RequestLogSearchResult>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.EvaluationColumnDefinition>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ReportColumnSummary>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.DatasetRowCell>>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.DatasetRowCell>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.DatasetRowCell, global::PromptLayer.EvaluationRowCell>>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TableSheetOperation>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateTableSheetOperationRequestStatuse>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TableSheetScoreColumn>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?>>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<double?, string, global::PromptLayer.TableSheetScoreCellObject>?>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TableSheetScoreMetric>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TableSheetScorecardStep>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.MigrateLegacyTableSheetScoreResponseSkippedItem>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TableSheetScorecardRowSummary>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TableSheetVersion>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TableCell>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CustomAnalyticsSeriesSpec>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.DerivedRatioInsightSpec>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CustomAnalyticsSeriesMeta>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.DerivedRatioInsightResult>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CustomAnalyticsSpec>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CustomAnalyticsResult>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.TraceStructuredFilter, global::PromptLayer.TraceStructuredFilterGroup>>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TraceCustomChartSpecHierarchyField>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TraceCustomChartSpecSerie>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.TraceCustomChartSpec>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateTableSheetColumnRequestDependencie>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.UpdateTableSheetColumnRequestDependencie>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.OneOf<string, global::System.Collections.Generic.List<string>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetReportResponseReportColumn>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Dataset>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Evaluation>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListWorkflowsResponseItem>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseNode>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseEdge>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListToolRegistriesResponseToolRegistrie>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Table>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Sheet>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Column>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Cell>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListTableSheetRowsResponseDataItem>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.AddTableSheetRowsResponseRow>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListWorkspaceEnvVarsResponseWorkspaceEnvVar>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListToolEnvVarsResponseToolEnvVar>? ListType106 { get; set; }
    }
}