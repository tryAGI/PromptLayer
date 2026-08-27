#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.ToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A custom function tool definition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.FunctionTool? Function { get; init; }
#else
        public global::PromptLayer.FunctionTool? Function { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.FunctionTool? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.FunctionTool PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// A provider-native built-in tool (e.g. web search, code interpreter, bash).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.BuiltInTool? WebSearch { get; init; }
#else
        public global::PromptLayer.BuiltInTool? WebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.BuiltInTool? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.BuiltInTool PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::PromptLayer.FunctionTool value) => new Tool((global::PromptLayer.FunctionTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.FunctionTool?(Tool @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::PromptLayer.FunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromFunction(global::PromptLayer.FunctionTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::PromptLayer.BuiltInTool value) => new Tool((global::PromptLayer.BuiltInTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.BuiltInTool?(Tool @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::PromptLayer.BuiltInTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromWebSearch(global::PromptLayer.BuiltInTool? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public Tool(
            global::PromptLayer.ToolDiscriminatorType? type,
            global::PromptLayer.FunctionTool? function,
            global::PromptLayer.BuiltInTool? webSearch
            )
        {
            Type = type;

            Function = function;
            WebSearch = webSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            WebSearch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsWebSearch || !IsFunction && IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::PromptLayer.FunctionTool, TResult>? function = null,
            global::System.Func<global::PromptLayer.BuiltInTool, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::PromptLayer.FunctionTool>? function = null,

            global::System.Action<global::PromptLayer.BuiltInTool>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::PromptLayer.FunctionTool>? function = null,
            global::System.Action<global::PromptLayer.BuiltInTool>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::PromptLayer.FunctionTool),
                WebSearch,
                typeof(global::PromptLayer.BuiltInTool),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.BuiltInTool?>.Default.Equals(WebSearch, other.WebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
