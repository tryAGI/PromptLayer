#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptTemplate : global::System.IEquatable<PromptTemplate>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.CompletionPrompt? Completion { get; init; }
#else
        public global::PromptLayer.CompletionPrompt? Completion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completion))]
#endif
        public bool IsCompletion => Completion != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompletion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.CompletionPrompt? value)
        {
            value = Completion;
            return IsCompletion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.CompletionPrompt PickCompletion() => IsCompletion
            ? Completion!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completion' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.ChatPrompt? Chat { get; init; }
#else
        public global::PromptLayer.ChatPrompt? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.ChatPrompt? value)
        {
            value = Chat;
            return IsChat;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::PromptLayer.ChatPrompt PickChat() => IsChat
            ? Chat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chat' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptTemplate(global::PromptLayer.CompletionPrompt value) => new PromptTemplate((global::PromptLayer.CompletionPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.CompletionPrompt?(PromptTemplate @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplate(global::PromptLayer.CompletionPrompt? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PromptTemplate FromCompletion(global::PromptLayer.CompletionPrompt? value) => new PromptTemplate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptTemplate(global::PromptLayer.ChatPrompt value) => new PromptTemplate((global::PromptLayer.ChatPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.ChatPrompt?(PromptTemplate @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplate(global::PromptLayer.ChatPrompt? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PromptTemplate FromChat(global::PromptLayer.ChatPrompt? value) => new PromptTemplate(value);

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplate(
            global::PromptLayer.GetPromptTemplateResponsePromptTemplateDiscriminatorType? type,
            global::PromptLayer.CompletionPrompt? completion,
            global::PromptLayer.ChatPrompt? chat
            )
        {
            Type = type;

            Completion = completion;
            Chat = chat;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Chat as object ??
            Completion as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Completion?.ToString() ??
            Chat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletion && !IsChat || !IsCompletion && IsChat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::PromptLayer.CompletionPrompt, TResult>? completion = null,
            global::System.Func<global::PromptLayer.ChatPrompt, TResult>? chat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion && completion != null)
            {
                return completion(Completion!);
            }
            else if (IsChat && chat != null)
            {
                return chat(Chat!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::PromptLayer.CompletionPrompt>? completion = null,

            global::System.Action<global::PromptLayer.ChatPrompt>? chat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion)
            {
                completion?.Invoke(Completion!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::PromptLayer.CompletionPrompt>? completion = null,
            global::System.Action<global::PromptLayer.ChatPrompt>? chat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion)
            {
                completion?.Invoke(Completion!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completion,
                typeof(global::PromptLayer.CompletionPrompt),
                Chat,
                typeof(global::PromptLayer.ChatPrompt),
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
        public bool Equals(PromptTemplate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.CompletionPrompt?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.ChatPrompt?>.Default.Equals(Chat, other.Chat) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptTemplate obj1, PromptTemplate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptTemplate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptTemplate obj1, PromptTemplate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptTemplate o && Equals(o);
        }
    }
}
