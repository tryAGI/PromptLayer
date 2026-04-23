
#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Comparison operator.
    /// </summary>
    public enum CreateDatasetVersionFromFilterParamsRequestScoreOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDatasetVersionFromFilterParamsRequestScoreOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetVersionFromFilterParamsRequestScoreOperator value)
        {
            return value switch
            {
                CreateDatasetVersionFromFilterParamsRequestScoreOperator.Lt => "<",
                CreateDatasetVersionFromFilterParamsRequestScoreOperator.Lte => "<=",
                CreateDatasetVersionFromFilterParamsRequestScoreOperator.Eq => "=",
                CreateDatasetVersionFromFilterParamsRequestScoreOperator.Gt => ">",
                CreateDatasetVersionFromFilterParamsRequestScoreOperator.Gte => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetVersionFromFilterParamsRequestScoreOperator? ToEnum(string value)
        {
            return value switch
            {
                "<" => CreateDatasetVersionFromFilterParamsRequestScoreOperator.Lt,
                "<=" => CreateDatasetVersionFromFilterParamsRequestScoreOperator.Lte,
                "=" => CreateDatasetVersionFromFilterParamsRequestScoreOperator.Eq,
                ">" => CreateDatasetVersionFromFilterParamsRequestScoreOperator.Gt,
                ">=" => CreateDatasetVersionFromFilterParamsRequestScoreOperator.Gte,
                _ => null,
            };
        }
    }
}