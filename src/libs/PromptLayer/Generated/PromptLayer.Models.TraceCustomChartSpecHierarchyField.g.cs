
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceCustomChartSpecHierarchyField
    {
        /// <summary>
        /// 
        /// </summary>
        SpanKind,
        /// <summary>
        /// 
        /// </summary>
        SpanName,
        /// <summary>
        /// 
        /// </summary>
        SpanStatus,
        /// <summary>
        /// 
        /// </summary>
        SpanToolName,
        /// <summary>
        /// 
        /// </summary>
        SpanType,
        /// <summary>
        /// 
        /// </summary>
        TraceModelsUsed,
        /// <summary>
        /// 
        /// </summary>
        TraceName,
        /// <summary>
        /// 
        /// </summary>
        TracePromptIds,
        /// <summary>
        /// 
        /// </summary>
        TraceStatus,
        /// <summary>
        /// 
        /// </summary>
        TraceToolNames,
        /// <summary>
        /// 
        /// </summary>
        TraceWorkflowIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceCustomChartSpecHierarchyFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecHierarchyField value)
        {
            return value switch
            {
                TraceCustomChartSpecHierarchyField.SpanKind => "span_kind",
                TraceCustomChartSpecHierarchyField.SpanName => "span_name",
                TraceCustomChartSpecHierarchyField.SpanStatus => "span_status",
                TraceCustomChartSpecHierarchyField.SpanToolName => "span_tool_name",
                TraceCustomChartSpecHierarchyField.SpanType => "span_type",
                TraceCustomChartSpecHierarchyField.TraceModelsUsed => "trace_models_used",
                TraceCustomChartSpecHierarchyField.TraceName => "trace_name",
                TraceCustomChartSpecHierarchyField.TracePromptIds => "trace_prompt_ids",
                TraceCustomChartSpecHierarchyField.TraceStatus => "trace_status",
                TraceCustomChartSpecHierarchyField.TraceToolNames => "trace_tool_names",
                TraceCustomChartSpecHierarchyField.TraceWorkflowIds => "trace_workflow_ids",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecHierarchyField? ToEnum(string value)
        {
            return value switch
            {
                "span_kind" => TraceCustomChartSpecHierarchyField.SpanKind,
                "span_name" => TraceCustomChartSpecHierarchyField.SpanName,
                "span_status" => TraceCustomChartSpecHierarchyField.SpanStatus,
                "span_tool_name" => TraceCustomChartSpecHierarchyField.SpanToolName,
                "span_type" => TraceCustomChartSpecHierarchyField.SpanType,
                "trace_models_used" => TraceCustomChartSpecHierarchyField.TraceModelsUsed,
                "trace_name" => TraceCustomChartSpecHierarchyField.TraceName,
                "trace_prompt_ids" => TraceCustomChartSpecHierarchyField.TracePromptIds,
                "trace_status" => TraceCustomChartSpecHierarchyField.TraceStatus,
                "trace_tool_names" => TraceCustomChartSpecHierarchyField.TraceToolNames,
                "trace_workflow_ids" => TraceCustomChartSpecHierarchyField.TraceWorkflowIds,
                _ => null,
            };
        }
    }
}