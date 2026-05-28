#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesItem : global::System.IEquatable<MessagesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ChatPromptMessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.SystemMessage? System { get; init; }
#else
        public global::PromptLayer.SystemMessage? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.SystemMessage? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.SystemMessage PickSystem() => IsSystem
            ? System!
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.UserMessage? User { get; init; }
#else
        public global::PromptLayer.UserMessage? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.UserMessage? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.UserMessage PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.AssistantMessage? Assistant { get; init; }
#else
        public global::PromptLayer.AssistantMessage? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAssistant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.AssistantMessage? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.AssistantMessage PickAssistant() => IsAssistant
            ? Assistant!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.FunctionMessage? Function { get; init; }
#else
        public global::PromptLayer.FunctionMessage? Function { get; }
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
            out global::PromptLayer.FunctionMessage? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.FunctionMessage PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ToolMessage? Tool { get; init; }
#else
        public global::PromptLayer.ToolMessage? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ToolMessage? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ToolMessage PickTool() => IsTool
            ? Tool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.PlaceholderMessage? Placeholder { get; init; }
#else
        public global::PromptLayer.PlaceholderMessage? Placeholder { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Placeholder))]
#endif
        public bool IsPlaceholder => Placeholder != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlaceholder(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.PlaceholderMessage? value)
        {
            value = Placeholder;
            return IsPlaceholder;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.PlaceholderMessage PickPlaceholder() => IsPlaceholder
            ? Placeholder!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Placeholder' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.DeveloperMessage? Developer { get; init; }
#else
        public global::PromptLayer.DeveloperMessage? Developer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Developer))]
#endif
        public bool IsDeveloper => Developer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeveloper(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.DeveloperMessage? value)
        {
            value = Developer;
            return IsDeveloper;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.DeveloperMessage PickDeveloper() => IsDeveloper
            ? Developer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Developer' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::PromptLayer.SystemMessage value) => new MessagesItem((global::PromptLayer.SystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.SystemMessage?(MessagesItem @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::PromptLayer.SystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesItem FromSystem(global::PromptLayer.SystemMessage? value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::PromptLayer.UserMessage value) => new MessagesItem((global::PromptLayer.UserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.UserMessage?(MessagesItem @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::PromptLayer.UserMessage? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesItem FromUser(global::PromptLayer.UserMessage? value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::PromptLayer.AssistantMessage value) => new MessagesItem((global::PromptLayer.AssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.AssistantMessage?(MessagesItem @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::PromptLayer.AssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesItem FromAssistant(global::PromptLayer.AssistantMessage? value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::PromptLayer.FunctionMessage value) => new MessagesItem((global::PromptLayer.FunctionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.FunctionMessage?(MessagesItem @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::PromptLayer.FunctionMessage? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesItem FromFunction(global::PromptLayer.FunctionMessage? value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::PromptLayer.ToolMessage value) => new MessagesItem((global::PromptLayer.ToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ToolMessage?(MessagesItem @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::PromptLayer.ToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesItem FromTool(global::PromptLayer.ToolMessage? value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::PromptLayer.PlaceholderMessage value) => new MessagesItem((global::PromptLayer.PlaceholderMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.PlaceholderMessage?(MessagesItem @this) => @this.Placeholder;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::PromptLayer.PlaceholderMessage? value)
        {
            Placeholder = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesItem FromPlaceholder(global::PromptLayer.PlaceholderMessage? value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::PromptLayer.DeveloperMessage value) => new MessagesItem((global::PromptLayer.DeveloperMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.DeveloperMessage?(MessagesItem @this) => @this.Developer;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::PromptLayer.DeveloperMessage? value)
        {
            Developer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesItem FromDeveloper(global::PromptLayer.DeveloperMessage? value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(
            global::PromptLayer.ChatPromptMessageDiscriminatorRole? role,
            global::PromptLayer.SystemMessage? system,
            global::PromptLayer.UserMessage? user,
            global::PromptLayer.AssistantMessage? assistant,
            global::PromptLayer.FunctionMessage? function,
            global::PromptLayer.ToolMessage? tool,
            global::PromptLayer.PlaceholderMessage? placeholder,
            global::PromptLayer.DeveloperMessage? developer
            )
        {
            Role = role;

            System = system;
            User = user;
            Assistant = assistant;
            Function = function;
            Tool = tool;
            Placeholder = placeholder;
            Developer = developer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Developer as object ??
            Placeholder as object ??
            Tool as object ??
            Function as object ??
            Assistant as object ??
            User as object ??
            System as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            System?.ToString() ??
            User?.ToString() ??
            Assistant?.ToString() ??
            Function?.ToString() ??
            Tool?.ToString() ??
            Placeholder?.ToString() ??
            Developer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystem && !IsUser && !IsAssistant && !IsFunction && !IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && IsUser && !IsAssistant && !IsFunction && !IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && IsAssistant && !IsFunction && !IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && !IsAssistant && IsFunction && !IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && !IsAssistant && !IsFunction && IsTool && !IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && !IsAssistant && !IsFunction && !IsTool && IsPlaceholder && !IsDeveloper || !IsSystem && !IsUser && !IsAssistant && !IsFunction && !IsTool && !IsPlaceholder && IsDeveloper;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::PromptLayer.SystemMessage, TResult>? system = null,
            global::System.Func<global::PromptLayer.UserMessage, TResult>? user = null,
            global::System.Func<global::PromptLayer.AssistantMessage, TResult>? assistant = null,
            global::System.Func<global::PromptLayer.FunctionMessage, TResult>? function = null,
            global::System.Func<global::PromptLayer.ToolMessage, TResult>? tool = null,
            global::System.Func<global::PromptLayer.PlaceholderMessage, TResult>? placeholder = null,
            global::System.Func<global::PromptLayer.DeveloperMessage, TResult>? developer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsPlaceholder && placeholder != null)
            {
                return placeholder(Placeholder!);
            }
            else if (IsDeveloper && developer != null)
            {
                return developer(Developer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::PromptLayer.SystemMessage>? system = null,

            global::System.Action<global::PromptLayer.UserMessage>? user = null,

            global::System.Action<global::PromptLayer.AssistantMessage>? assistant = null,

            global::System.Action<global::PromptLayer.FunctionMessage>? function = null,

            global::System.Action<global::PromptLayer.ToolMessage>? tool = null,

            global::System.Action<global::PromptLayer.PlaceholderMessage>? placeholder = null,

            global::System.Action<global::PromptLayer.DeveloperMessage>? developer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsPlaceholder)
            {
                placeholder?.Invoke(Placeholder!);
            }
            else if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::PromptLayer.SystemMessage>? system = null,
            global::System.Action<global::PromptLayer.UserMessage>? user = null,
            global::System.Action<global::PromptLayer.AssistantMessage>? assistant = null,
            global::System.Action<global::PromptLayer.FunctionMessage>? function = null,
            global::System.Action<global::PromptLayer.ToolMessage>? tool = null,
            global::System.Action<global::PromptLayer.PlaceholderMessage>? placeholder = null,
            global::System.Action<global::PromptLayer.DeveloperMessage>? developer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsPlaceholder)
            {
                placeholder?.Invoke(Placeholder!);
            }
            else if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                System,
                typeof(global::PromptLayer.SystemMessage),
                User,
                typeof(global::PromptLayer.UserMessage),
                Assistant,
                typeof(global::PromptLayer.AssistantMessage),
                Function,
                typeof(global::PromptLayer.FunctionMessage),
                Tool,
                typeof(global::PromptLayer.ToolMessage),
                Placeholder,
                typeof(global::PromptLayer.PlaceholderMessage),
                Developer,
                typeof(global::PromptLayer.DeveloperMessage),
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
        public bool Equals(MessagesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.SystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.UserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.AssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.FunctionMessage?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ToolMessage?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.PlaceholderMessage?>.Default.Equals(Placeholder, other.Placeholder) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.DeveloperMessage?>.Default.Equals(Developer, other.Developer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesItem obj1, MessagesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesItem obj1, MessagesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesItem o && Equals(o);
        }
    }
}
