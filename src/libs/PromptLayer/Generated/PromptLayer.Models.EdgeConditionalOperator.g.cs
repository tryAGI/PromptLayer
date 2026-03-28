
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Comparison operator.
    /// </summary>
    public enum EdgeConditionalOperator
    {
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x_2,
        /// <summary>
        /// 
        /// </summary>
        x__2,
        /// <summary>
        /// 
        /// </summary>
        x_,
        /// <summary>
        /// 
        /// </summary>
        x_3,
        /// <summary>
        /// 
        /// </summary>
        x__3,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        IsNotNull,
        /// <summary>
        /// 
        /// </summary>
        IsNull,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EdgeConditionalOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EdgeConditionalOperator value)
        {
            return value switch
            {
                EdgeConditionalOperator.x__ => "!=",
                EdgeConditionalOperator.x_2 => "<",
                EdgeConditionalOperator.x__2 => "<=",
                EdgeConditionalOperator.x_ => "=",
                EdgeConditionalOperator.x_3 => ">",
                EdgeConditionalOperator.x__3 => ">=",
                EdgeConditionalOperator.In => "in",
                EdgeConditionalOperator.IsNotNull => "is_not_null",
                EdgeConditionalOperator.IsNull => "is_null",
                EdgeConditionalOperator.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EdgeConditionalOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => EdgeConditionalOperator.x__,
                "<" => EdgeConditionalOperator.x_2,
                "<=" => EdgeConditionalOperator.x__2,
                "=" => EdgeConditionalOperator.x_,
                ">" => EdgeConditionalOperator.x_3,
                ">=" => EdgeConditionalOperator.x__3,
                "in" => EdgeConditionalOperator.In,
                "is_not_null" => EdgeConditionalOperator.IsNotNull,
                "is_null" => EdgeConditionalOperator.IsNull,
                "not_in" => EdgeConditionalOperator.NotIn,
                _ => null,
            };
        }
    }
}