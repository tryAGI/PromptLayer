
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Heatmap charts only
    /// </summary>
    public enum TraceCustomChartSpecSecondaryGroupByField
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
    public static class TraceCustomChartSpecSecondaryGroupByFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecSecondaryGroupByField value)
        {
            return value switch
            {
                TraceCustomChartSpecSecondaryGroupByField.SpanKind => "span_kind",
                TraceCustomChartSpecSecondaryGroupByField.SpanName => "span_name",
                TraceCustomChartSpecSecondaryGroupByField.SpanStatus => "span_status",
                TraceCustomChartSpecSecondaryGroupByField.SpanToolName => "span_tool_name",
                TraceCustomChartSpecSecondaryGroupByField.SpanType => "span_type",
                TraceCustomChartSpecSecondaryGroupByField.TraceModelsUsed => "trace_models_used",
                TraceCustomChartSpecSecondaryGroupByField.TraceName => "trace_name",
                TraceCustomChartSpecSecondaryGroupByField.TracePromptIds => "trace_prompt_ids",
                TraceCustomChartSpecSecondaryGroupByField.TraceStatus => "trace_status",
                TraceCustomChartSpecSecondaryGroupByField.TraceToolNames => "trace_tool_names",
                TraceCustomChartSpecSecondaryGroupByField.TraceWorkflowIds => "trace_workflow_ids",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecSecondaryGroupByField? ToEnum(string value)
        {
            return value switch
            {
                "span_kind" => TraceCustomChartSpecSecondaryGroupByField.SpanKind,
                "span_name" => TraceCustomChartSpecSecondaryGroupByField.SpanName,
                "span_status" => TraceCustomChartSpecSecondaryGroupByField.SpanStatus,
                "span_tool_name" => TraceCustomChartSpecSecondaryGroupByField.SpanToolName,
                "span_type" => TraceCustomChartSpecSecondaryGroupByField.SpanType,
                "trace_models_used" => TraceCustomChartSpecSecondaryGroupByField.TraceModelsUsed,
                "trace_name" => TraceCustomChartSpecSecondaryGroupByField.TraceName,
                "trace_prompt_ids" => TraceCustomChartSpecSecondaryGroupByField.TracePromptIds,
                "trace_status" => TraceCustomChartSpecSecondaryGroupByField.TraceStatus,
                "trace_tool_names" => TraceCustomChartSpecSecondaryGroupByField.TraceToolNames,
                "trace_workflow_ids" => TraceCustomChartSpecSecondaryGroupByField.TraceWorkflowIds,
                _ => null,
            };
        }
    }
}