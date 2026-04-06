
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
        public global::PromptLayer.Base? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Function? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FunctionCall? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.HTTPValidationError? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ValidationError>? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ValidationError? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.AnyOf<string, int?>>? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<string, int?>? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Model? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Metadata? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplate? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateProvider2? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CompletionPrompt? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentItem? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TextContent? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ThinkingContent? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CodeContent? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ImageContent? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MediaContent? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MediaVariable? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OutputMediaContent? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ServerToolUseContent? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.WebSearchToolResultContent? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CodeExecutionResultContent? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.McpListToolsContent? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.McpCallContent? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.McpApprovalRequestContent? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.McpApprovalResponseContent? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.BashCodeExecutionToolResultContent? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TextEditorCodeExecutionToolResultContent? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ShellCallContent? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ShellCallOutputContent? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ApplyPatchCallContent? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ApplyPatchCallOutputContent? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CompletionPromptContentItemDiscriminator? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CompletionPromptContentItemDiscriminatorType? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CompletionPromptTemplateFormat? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CompletionPromptType? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FileAnnotation? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.WebAnnotation? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MapAnnotation? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContainerFileAnnotation? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TextContentType? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ThinkingContentType? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ImageURL? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Media? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MediaFormat? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ImageContentType? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MediaContentType? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MediaVariableType? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OutputMediaContentType? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OutputMediaContentMediaType? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CodeContentType? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ServerToolUseContentType? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.WebSearchResult? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.WebSearchResultType? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.WebSearchToolResultContentType? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.WebSearchResult>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CodeExecutionResultContentType? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.McpListToolsContentType? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<string, object, object>? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.McpCallContentType? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.McpApprovalRequestContentType? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.McpApprovalResponseContentType? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.BashCodeExecutionToolResultContentType? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TextEditorCodeExecutionToolResultContentType? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ShellCallContentType? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ShellCallOutputContentType? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ApplyPatchCallContentType? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ApplyPatchCallOutputContentType? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.BuiltInTool? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.BuiltInToolType? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SystemMessage? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SystemMessageTemplateFormat? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem2>? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentItem2? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SystemMessageContentItemDiscriminator? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SystemMessageContentItemDiscriminatorType? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UserMessage? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UserMessageTemplateFormat? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem3>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentItem3? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UserMessageContentItemDiscriminator? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UserMessageContentItemDiscriminatorType? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AssistantMessage? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AssistantMessageTemplateFormat? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item>? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentVariant1Item? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminator? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AssistantMessageContentVariant1ItemDiscriminatorType? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ToolCall>? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ToolCall? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FunctionMessage? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FunctionMessageTemplateFormat? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item2>? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentVariant1Item2? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminator? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FunctionMessageContentVariant1ItemDiscriminatorType? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeveloperMessage? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeveloperMessageTemplateFormat? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem4>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentItem4? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeveloperMessageContentItemDiscriminator? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeveloperMessageContentItemDiscriminatorType? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MessageFunctionCall? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ChatPrompt? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.MessagesItem>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MessagesItem? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ToolMessage? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessage? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ChatPromptMessageDiscriminator? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ChatPromptMessageDiscriminatorRole? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Function>? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Tool>? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Tool? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::PromptLayer.MessageFunctionCall, object>? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::PromptLayer.ChatToolChoice, object>? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ChatToolChoice? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ChatPromptType? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateResponse? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplate? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminator? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SnippetReference? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateRawResponse? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplate2? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateRawResponsePromptTemplateDiscriminator? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateRawResponsePromptTemplateDiscriminatorType? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.SnippetReference>? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateLabelResponse? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel>? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.BasePromptTemplate? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptVersion? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplate3? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptVersionPromptTemplateDiscriminator? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptVersionPromptTemplateDiscriminatorType? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PatchPromptTemplateVersion? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreatePromptTemplate? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreatePromptTemplateResponse? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplate4? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreatePromptTemplateResponsePromptTemplateDiscriminator? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreatePromptTemplateResponsePromptTemplateDiscriminatorType? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ToolMessageTemplateFormat? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentItem5>? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentItem5? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ToolMessageContentItemDiscriminator? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ToolMessageContentItemDiscriminatorType? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FunctionTool? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ToolDiscriminator? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ToolDiscriminatorType? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListPromptTemplates? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetPromptTemplateResponse>? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageTemplateFormat? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ContentVariant1Item3>? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ContentVariant1Item3? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminator? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageContentVariant1ItemDiscriminatorType? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessageRole? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequest? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Input? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestInputDiscriminator? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestInputDiscriminatorType? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Output? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestOutputDiscriminator? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestOutputDiscriminatorType? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestStatus? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestErrorType2? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestResponse? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.LogRequestResponseStatus? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.BadRequestError? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptBlueprint? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplate5? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptBlueprintPromptTemplateDiscriminator? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptBlueprintPromptTemplateDiscriminatorType? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SpanKind? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StatusCode? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SpanContext? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SpanStatus? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SpanResource? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Span? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateSpansBulk? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Span>? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateSpansBulkResponse? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Dataset? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DatasetGroup? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateFolderRequest? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateFolderSuccessResponse? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.Folder? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FolderExistsError? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ParentFolderNotFoundError? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UnauthorizedError? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FolderNotFoundError? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UpdateFolderRequest? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EntityType? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FolderEntity? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.PromptEntityMetadata, global::PromptLayer.WorkflowEntityMetadata, global::PromptLayer.DatasetEntityMetadata, object>? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptEntityMetadata? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.WorkflowEntityMetadata? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DatasetEntityMetadata? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptEntityMetadataType? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesResponse? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.FolderEntity>? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.EntityReference? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.MoveFolderEntitiesRequest? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.EntityReference>? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeleteFolderEntitiesRequest? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FolderEntitiesCountResponse? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ResolveFolderIdResponse? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequest? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanResource? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpKeyValue>? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpKeyValue? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan>? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpanScope? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpan>? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpSpan? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpSpanStatus? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpanEvent>? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpSpanEvent? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OtlpSpanLink>? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpSpanLink? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpKeyValueValue? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpKeyValueValueArrayValue? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceResponse? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OtlpExportTraceServiceResponsePartialSuccess? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SearchRequestLogsRequest? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilterGroup? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SearchRequestLogsRequestSortBy? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SearchRequestLogsRequestSortOrder? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilter? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilterField? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilterOperator? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<string, double?, bool?, byte[], object>? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.StructuredFilterGroupLogic? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SearchRequestLogsResponse? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreatePromptLabelRequest? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchRequest? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackMetadataRequest? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackGroupRequest? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackPromptRequest? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackScoreRequest? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequest? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateEvaluationPipelineRequestColumn>? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequestColumn? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequestScoreConfiguration? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnRequest? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnRequestColumnType? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportRequest? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetGroupRequest? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFileRequest? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequest? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScores2>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsRequestScores2? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDraftDatasetVersionRequest? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddRequestLogToDatasetVersionRequest? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SaveDraftDatasetVersionRequest? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListDatasetsStatus? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListEvaluationsStatus? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetAllPromptTemplatesGetStatus? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.IngestOtlpTracesContentType? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.IngestOtlpTracesContentEncoding? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetRequestSearchSuggestionsField? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreatePromptLabelResponse? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PromptTemplatesLabelsPromptLabelIdPatchResponse? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackMetadataResponse? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackGroupResponse? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackPromptResponse? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.TrackScoreResponse? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeleteReportsByNameResponse? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.CreateEvaluationPipelineResponseReportColumn>? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponseReportColumn? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse2? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse3? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateEvaluationPipelineResponse4? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse2? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse3? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddReportColumnResponse4? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse2? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse3? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse4? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.RunReportResponse5? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponse? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponseReport? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponseStatus? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponseStats? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportResponseStatsStatusCounts? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponse? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScore? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreScoreType? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant1? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant3? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetReportScoreResponseScoreDetailsVariant4? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListDatasetsResponse? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Dataset>? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetRequestResponse? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetRequestResponsePromptBlueprint? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetTraceResponse? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetTraceResponseSpan>? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetTraceResponseSpan? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetDatasetRowsResponse? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.GetDatasetRowsResponseRowItem>>? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetDatasetRowsResponseRowItem>? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetDatasetRowsResponseRowItem? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetDatasetRowsResponseRowItemType? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetEvaluationRowsResponse? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::PromptLayer.GetEvaluationRowsResponseRowItem>>? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetEvaluationRowsResponseRowItem>? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetEvaluationRowsResponseRowItem? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetEvaluationRowsResponseRowItemType? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetEvaluationRowsResponseRowItemStatus? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListEvaluationsResponse? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.Evaluation>? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetGroupResponse? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFileResponse? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDatasetVersionFromFilterParamsResponse? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDraftDatasetVersionResponse? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CreateDraftDatasetVersionResponse2? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AddRequestLogToDatasetVersionResponse? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SaveDraftDatasetVersionResponse? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<global::PromptLayer.BadRequestError, global::PromptLayer.ValidationError>? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>, object>? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12>? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant12? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.OneOf<global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>, object>? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14>? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowVersionExecutionResultsResponseVariant14? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.ListWorkflowsResponseItem>? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponseItem? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse2? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ListWorkflowsResponse3? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowResponse? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowResponseNode>? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowResponseNode? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowResponseEdge>? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowResponseEdge? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowLabelsResponse? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<global::PromptLayer.FolderExistsError, string>? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetRequestSearchSuggestionsResponse? Type400 { get; set; }

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
        public global::System.Collections.Generic.List<global::PromptLayer.ValidationError>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.AnyOf<string, int?>>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.WebAnnotation, global::PromptLayer.FileAnnotation, global::PromptLayer.MapAnnotation, global::PromptLayer.ContainerFileAnnotation>>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.WebSearchResult>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem2>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem3>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ToolCall>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item2>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem4>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.MessagesItem>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Function>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Tool>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.SnippetReference>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetPromptTemplateLabelResponseReleaseLabel>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<object, global::System.Collections.Generic.List<object>, object>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentItem5>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetPromptTemplateResponse>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ContentVariant1Item3>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Span>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.FolderEntity>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.EntityReference>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpan>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpKeyValue>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpExportTraceServiceRequestResourceSpanScopeSpan>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpan>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpanEvent>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OtlpSpanLink>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.OneOf<global::PromptLayer.StructuredFilter, global::PromptLayer.StructuredFilterGroup>>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateEvaluationPipelineRequestColumn>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.CreateEvaluationPipelineResponseReportColumn>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetReportScoreResponseScoreDetailsVariant2Column>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Dataset>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetTraceResponseSpan>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.GetDatasetRowsResponseRowItem>>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetDatasetRowsResponseRowItem>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::PromptLayer.GetEvaluationRowsResponseRowItem>>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetEvaluationRowsResponseRowItem>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.Evaluation>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.ListWorkflowsResponseItem>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseNode>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowResponseEdge>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::PromptLayer.GetWorkflowLabelsResponseReleaseLabel>? ListType55 { get; set; }
    }
}