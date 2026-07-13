
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceCustomChartSpecGroupByField
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
    public static class TraceCustomChartSpecGroupByFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceCustomChartSpecGroupByField value)
        {
            return value switch
            {
                TraceCustomChartSpecGroupByField.SpanKind => "span_kind",
                TraceCustomChartSpecGroupByField.SpanName => "span_name",
                TraceCustomChartSpecGroupByField.SpanStatus => "span_status",
                TraceCustomChartSpecGroupByField.SpanToolName => "span_tool_name",
                TraceCustomChartSpecGroupByField.SpanType => "span_type",
                TraceCustomChartSpecGroupByField.TraceModelsUsed => "trace_models_used",
                TraceCustomChartSpecGroupByField.TraceName => "trace_name",
                TraceCustomChartSpecGroupByField.TracePromptIds => "trace_prompt_ids",
                TraceCustomChartSpecGroupByField.TraceStatus => "trace_status",
                TraceCustomChartSpecGroupByField.TraceToolNames => "trace_tool_names",
                TraceCustomChartSpecGroupByField.TraceWorkflowIds => "trace_workflow_ids",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceCustomChartSpecGroupByField? ToEnum(string value)
        {
            return value switch
            {
                "span_kind" => TraceCustomChartSpecGroupByField.SpanKind,
                "span_name" => TraceCustomChartSpecGroupByField.SpanName,
                "span_status" => TraceCustomChartSpecGroupByField.SpanStatus,
                "span_tool_name" => TraceCustomChartSpecGroupByField.SpanToolName,
                "span_type" => TraceCustomChartSpecGroupByField.SpanType,
                "trace_models_used" => TraceCustomChartSpecGroupByField.TraceModelsUsed,
                "trace_name" => TraceCustomChartSpecGroupByField.TraceName,
                "trace_prompt_ids" => TraceCustomChartSpecGroupByField.TracePromptIds,
                "trace_status" => TraceCustomChartSpecGroupByField.TraceStatus,
                "trace_tool_names" => TraceCustomChartSpecGroupByField.TraceToolNames,
                "trace_workflow_ids" => TraceCustomChartSpecGroupByField.TraceWorkflowIds,
                _ => null,
            };
        }
    }
}