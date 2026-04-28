
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
        public global::PromptLayer.GetSnippetUsageResponse? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetSnippetUsageResponseLabelUsageItem>? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetSnippetUsageResponseLabelUsageItem? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunWorkflow? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunWorkflowResponse? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.WorkflowNode? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EdgeConditional? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EdgeConditionalOperator? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Edge? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.EdgeConditional>? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateWorkflow? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.WorkflowNode>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Edge>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.NodeUpdate? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PatchWorkflow? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.NodeUpdate, object>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateWorkflowResponse? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateWorkflowResponseNode>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateWorkflowResponseNode? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ErrorResponse? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SkillCollectionErrorResponse? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SkillCollection? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SkillCollectionVersion? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.InitialFileUpdate? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FileUpdate? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FileMove? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateSkillCollectionRequest? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.InitialFileUpdate>? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateSkillCollectionMultipartRequest? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UpdateSkillCollectionRequest? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SaveSkillCollectionVersionRequest? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.FileUpdate>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.FileMove>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SaveSkillCollectionVersionMultipartRequest? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListSkillCollectionsResponse? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.SkillCollection>? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetSkillCollectionResponse? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.SkillCollectionVersion, object>? Type54 { get; set; }
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
        public global::System.Collections.Generic.IList<global::PromptLayer.GetPromptTemplateResponse>? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageTemplateFormat? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item3>? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentVariant1Item3? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminator? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageRole? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequest? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Input? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestInputDiscriminator? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestInputDiscriminatorType? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Output? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestOutputDiscriminator? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestOutputDiscriminatorType? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestStatus? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestErrorType2? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestResponse? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestResponseStatus? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.BadRequestError? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptBlueprint? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplate5? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptBlueprintPromptTemplateDiscriminator? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptBlueprintPromptTemplateDiscriminatorType? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SpanKind? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StatusCode? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SpanContext? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SpanStatus? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SpanResource? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Span? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateSpansBulk? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Span>? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateSpansBulkResponse? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Dataset? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DatasetGroup? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateFolderRequest? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateFolderSuccessResponse? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Folder? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FolderExistsError? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ParentFolderNotFoundError? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UnauthorizedError? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FolderNotFoundError? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UpdateFolderRequest? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EntityType? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FolderEntity? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptEntityMetadata? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.WorkflowEntityMetadata? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DatasetEntityMetadata? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptEntityMetadataType? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesResponse? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.FolderEntity>? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EntityReference? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MoveFolderEntitiesRequest? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.EntityReference>? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeleteFolderEntitiesRequest? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FolderEntitiesCountResponse? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ResolveFolderIdResponse? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequest? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanResource? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpKeyValue>? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpKeyValue? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan>? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpanScope? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpan>? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpSpan? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpSpanStatus? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpanEvent>? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpSpanEvent? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpanLink>? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpSpanLink? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpKeyValueValue? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpKeyValueValueArrayValue? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceResponse? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceResponsePartialSuccess? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SearchRequestLogsRequest? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilterGroup? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SearchRequestLogsRequestSortBy? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SearchRequestLogsRequestSortOrder? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilter? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilterField? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilterOperator? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<string, double?, bool?, byte[], object>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilterGroupLogic? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SearchRequestLogsResponse? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreatePromptLabelRequest? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchRequest? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackMetadataRequest? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackGroupRequest? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackPromptRequest? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackScoreRequest? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequest? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateEvaluationPipelineRequestColumn>? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequestColumn? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequestScoreConfiguration? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnRequest? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnRequestColumnType? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportRequest? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RenameReportRequest? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EditReportColumnRequest? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EditReportColumnRequestColumnType? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetGroupRequest? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFileRequest? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataAndItem>? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataAndItem? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataOrItem>? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataOrItem? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem>? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesExcludeItem>? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesExcludeItem? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScore>? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScore? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScoreOperator? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestStatu>? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestStatu? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortBy? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestSortOrder? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDraftDatasetVersionRequest? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddRequestLogToDatasetVersionRequest? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SaveDraftDatasetVersionRequest? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateToolRegistryRequest? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListDatasetsStatus? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListEvaluationsStatus? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetAllPromptTemplatesGetStatus? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.IngestOtlpTracesContentType? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.IngestOtlpTracesContentEncoding? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetSkillCollectionPublicFormat? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetRequestSearchSuggestionsField? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreatePromptLabelResponse? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchResponse? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackMetadataResponse? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackGroupResponse? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackPromptResponse? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackScoreResponse? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeleteReportsByNameResponse? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateEvaluationPipelineResponseReportColumn>? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponseReportColumn? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse2? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse3? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse4? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse2? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse3? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse4? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse2? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse3? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse4? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse5? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponse? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponseReport? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponseStatus? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponseStats? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponseStatsStatusCounts? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeleteReportResponse? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponse? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScore? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreScoreType? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RenameReportResponse? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EditReportColumnResponse? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListDatasetsResponse? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Dataset>? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetRequestResponse? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetRequestResponsePromptBlueprint? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetTraceResponse? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetTraceResponseSpan>? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetTraceResponseSpan? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetDatasetRowsResponse? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.GetDatasetRowsResponseRowItem>>? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetDatasetRowsResponseRowItem>? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetDatasetRowsResponseRowItem? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetDatasetRowsResponseRowItemType? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetEvaluationRowsResponse? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.GetEvaluationRowsResponseRowItem>>? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetEvaluationRowsResponseRowItem>? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetEvaluationRowsResponseRowItem? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetEvaluationRowsResponseRowItemType? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetEvaluationRowsResponseRowItemStatus? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListEvaluationsResponse? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Evaluation>? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetGroupResponse? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFileResponse? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDraftDatasetVersionResponse? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDraftDatasetVersionResponse2? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddRequestLogToDatasetVersionResponse? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SaveDraftDatasetVersionResponse? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListWorkflowsResponseItem>? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponseItem? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse2? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse3? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowResponse? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowResponseNode>? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowResponseNode? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowResponseEdge>? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowResponseEdge? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowLabelsResponse? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<global::PromptLayer.FolderExistsError, string>? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetRequestSearchSuggestionsResponse? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListToolRegistriesResponse? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListToolRegistriesResponseToolRegistrie>? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListToolRegistriesResponseToolRegistrie? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateToolRegistryResponse? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetToolRegistryResponse? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetToolRegistryResponseToolRegistry? Type449 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.EvaluationRun>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetSnippetUsageResponseSnippetUsageItem>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetSnippetUsageResponseLabelUsageItem>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.EdgeConditional>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.WorkflowNode>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Edge>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateWorkflowResponseNode>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.InitialFileUpdate>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.FileUpdate>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.FileMove>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.SkillCollection>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ValidationError>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.WebSearchResult>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem2>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem3>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ToolCall>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item2>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem4>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.MessagesItem>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Function>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Tool>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.SnippetReference>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.List<object>, object>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem5>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetPromptTemplateResponse>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item3>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Span>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.FolderEntity>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.EntityReference>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpKeyValue>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpan>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpanEvent>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpanLink>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateEvaluationPipelineRequestColumn>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataAndItem>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestMetadataOrItem>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesIncludeItem>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestPromptTemplatesExcludeItem>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScore>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestStatu>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateEvaluationPipelineResponseReportColumn>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Dataset>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetTraceResponseSpan>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.GetDatasetRowsResponseRowItem>>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetDatasetRowsResponseRowItem>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.GetEvaluationRowsResponseRowItem>>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetEvaluationRowsResponseRowItem>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Evaluation>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListWorkflowsResponseItem>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseNode>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseEdge>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListToolRegistriesResponseToolRegistrie>? ListType66 { get; set; }
    }
}