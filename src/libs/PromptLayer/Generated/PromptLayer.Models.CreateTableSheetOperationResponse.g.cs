#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PromptLayer
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateTableSheetOperationResponse : global::System.IEquatable<CreateTableSheetOperationResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.CreateTableSheetOperationQueuedResponse? CreateTableSheetOperationQueuedResponse { get; init; }
#else
        public global::PromptLayer.CreateTableSheetOperationQueuedResponse? CreateTableSheetOperationQueuedResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateTableSheetOperationQueuedResponse))]
#endif
        public bool IsCreateTableSheetOperationQueuedResponse => CreateTableSheetOperationQueuedResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateTableSheetOperationQueuedResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.CreateTableSheetOperationQueuedResponse? value)
        {
            value = CreateTableSheetOperationQueuedResponse;
            return IsCreateTableSheetOperationQueuedResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationQueuedResponse PickCreateTableSheetOperationQueuedResponse() => IsCreateTableSheetOperationQueuedResponse
            ? CreateTableSheetOperationQueuedResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateTableSheetOperationQueuedResponse' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.CreateTableSheetOperationNoopResponse? CreateTableSheetOperationNoopResponse { get; init; }
#else
        public global::PromptLayer.CreateTableSheetOperationNoopResponse? CreateTableSheetOperationNoopResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateTableSheetOperationNoopResponse))]
#endif
        public bool IsCreateTableSheetOperationNoopResponse => CreateTableSheetOperationNoopResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateTableSheetOperationNoopResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.CreateTableSheetOperationNoopResponse? value)
        {
            value = CreateTableSheetOperationNoopResponse;
            return IsCreateTableSheetOperationNoopResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationNoopResponse PickCreateTableSheetOperationNoopResponse() => IsCreateTableSheetOperationNoopResponse
            ? CreateTableSheetOperationNoopResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateTableSheetOperationNoopResponse' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.CreateTableSheetOperationConfirmationResponse? CreateTableSheetOperationConfirmationResponse { get; init; }
#else
        public global::PromptLayer.CreateTableSheetOperationConfirmationResponse? CreateTableSheetOperationConfirmationResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateTableSheetOperationConfirmationResponse))]
#endif
        public bool IsCreateTableSheetOperationConfirmationResponse => CreateTableSheetOperationConfirmationResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateTableSheetOperationConfirmationResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.CreateTableSheetOperationConfirmationResponse? value)
        {
            value = CreateTableSheetOperationConfirmationResponse;
            return IsCreateTableSheetOperationConfirmationResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::PromptLayer.CreateTableSheetOperationConfirmationResponse PickCreateTableSheetOperationConfirmationResponse() => IsCreateTableSheetOperationConfirmationResponse
            ? CreateTableSheetOperationConfirmationResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateTableSheetOperationConfirmationResponse' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTableSheetOperationResponse(global::PromptLayer.CreateTableSheetOperationQueuedResponse value) => new CreateTableSheetOperationResponse((global::PromptLayer.CreateTableSheetOperationQueuedResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.CreateTableSheetOperationQueuedResponse?(CreateTableSheetOperationResponse @this) => @this.CreateTableSheetOperationQueuedResponse;

        /// <summary>
        ///
        /// </summary>
        public CreateTableSheetOperationResponse(global::PromptLayer.CreateTableSheetOperationQueuedResponse? value)
        {
            CreateTableSheetOperationQueuedResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTableSheetOperationResponse FromCreateTableSheetOperationQueuedResponse(global::PromptLayer.CreateTableSheetOperationQueuedResponse? value) => new CreateTableSheetOperationResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTableSheetOperationResponse(global::PromptLayer.CreateTableSheetOperationNoopResponse value) => new CreateTableSheetOperationResponse((global::PromptLayer.CreateTableSheetOperationNoopResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.CreateTableSheetOperationNoopResponse?(CreateTableSheetOperationResponse @this) => @this.CreateTableSheetOperationNoopResponse;

        /// <summary>
        ///
        /// </summary>
        public CreateTableSheetOperationResponse(global::PromptLayer.CreateTableSheetOperationNoopResponse? value)
        {
            CreateTableSheetOperationNoopResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTableSheetOperationResponse FromCreateTableSheetOperationNoopResponse(global::PromptLayer.CreateTableSheetOperationNoopResponse? value) => new CreateTableSheetOperationResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateTableSheetOperationResponse(global::PromptLayer.CreateTableSheetOperationConfirmationResponse value) => new CreateTableSheetOperationResponse((global::PromptLayer.CreateTableSheetOperationConfirmationResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::PromptLayer.CreateTableSheetOperationConfirmationResponse?(CreateTableSheetOperationResponse @this) => @this.CreateTableSheetOperationConfirmationResponse;

        /// <summary>
        ///
        /// </summary>
        public CreateTableSheetOperationResponse(global::PromptLayer.CreateTableSheetOperationConfirmationResponse? value)
        {
            CreateTableSheetOperationConfirmationResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateTableSheetOperationResponse FromCreateTableSheetOperationConfirmationResponse(global::PromptLayer.CreateTableSheetOperationConfirmationResponse? value) => new CreateTableSheetOperationResponse(value);

        /// <summary>
        ///
        /// </summary>
        public CreateTableSheetOperationResponse(
            global::PromptLayer.CreateTableSheetOperationQueuedResponse? createTableSheetOperationQueuedResponse,
            global::PromptLayer.CreateTableSheetOperationNoopResponse? createTableSheetOperationNoopResponse,
            global::PromptLayer.CreateTableSheetOperationConfirmationResponse? createTableSheetOperationConfirmationResponse
            )
        {
            CreateTableSheetOperationQueuedResponse = createTableSheetOperationQueuedResponse;
            CreateTableSheetOperationNoopResponse = createTableSheetOperationNoopResponse;
            CreateTableSheetOperationConfirmationResponse = createTableSheetOperationConfirmationResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateTableSheetOperationConfirmationResponse as object ??
            CreateTableSheetOperationNoopResponse as object ??
            CreateTableSheetOperationQueuedResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateTableSheetOperationQueuedResponse?.ToString() ??
            CreateTableSheetOperationNoopResponse?.ToString() ??
            CreateTableSheetOperationConfirmationResponse?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateTableSheetOperationQueuedResponse && !IsCreateTableSheetOperationNoopResponse && !IsCreateTableSheetOperationConfirmationResponse || !IsCreateTableSheetOperationQueuedResponse && IsCreateTableSheetOperationNoopResponse && !IsCreateTableSheetOperationConfirmationResponse || !IsCreateTableSheetOperationQueuedResponse && !IsCreateTableSheetOperationNoopResponse && IsCreateTableSheetOperationConfirmationResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::PromptLayer.CreateTableSheetOperationQueuedResponse, TResult>? createTableSheetOperationQueuedResponse = null,
            global::System.Func<global::PromptLayer.CreateTableSheetOperationNoopResponse, TResult>? createTableSheetOperationNoopResponse = null,
            global::System.Func<global::PromptLayer.CreateTableSheetOperationConfirmationResponse, TResult>? createTableSheetOperationConfirmationResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateTableSheetOperationQueuedResponse && createTableSheetOperationQueuedResponse != null)
            {
                return createTableSheetOperationQueuedResponse(CreateTableSheetOperationQueuedResponse!);
            }
            else if (IsCreateTableSheetOperationNoopResponse && createTableSheetOperationNoopResponse != null)
            {
                return createTableSheetOperationNoopResponse(CreateTableSheetOperationNoopResponse!);
            }
            else if (IsCreateTableSheetOperationConfirmationResponse && createTableSheetOperationConfirmationResponse != null)
            {
                return createTableSheetOperationConfirmationResponse(CreateTableSheetOperationConfirmationResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::PromptLayer.CreateTableSheetOperationQueuedResponse>? createTableSheetOperationQueuedResponse = null,

            global::System.Action<global::PromptLayer.CreateTableSheetOperationNoopResponse>? createTableSheetOperationNoopResponse = null,

            global::System.Action<global::PromptLayer.CreateTableSheetOperationConfirmationResponse>? createTableSheetOperationConfirmationResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateTableSheetOperationQueuedResponse)
            {
                createTableSheetOperationQueuedResponse?.Invoke(CreateTableSheetOperationQueuedResponse!);
            }
            else if (IsCreateTableSheetOperationNoopResponse)
            {
                createTableSheetOperationNoopResponse?.Invoke(CreateTableSheetOperationNoopResponse!);
            }
            else if (IsCreateTableSheetOperationConfirmationResponse)
            {
                createTableSheetOperationConfirmationResponse?.Invoke(CreateTableSheetOperationConfirmationResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::PromptLayer.CreateTableSheetOperationQueuedResponse>? createTableSheetOperationQueuedResponse = null,
            global::System.Action<global::PromptLayer.CreateTableSheetOperationNoopResponse>? createTableSheetOperationNoopResponse = null,
            global::System.Action<global::PromptLayer.CreateTableSheetOperationConfirmationResponse>? createTableSheetOperationConfirmationResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateTableSheetOperationQueuedResponse)
            {
                createTableSheetOperationQueuedResponse?.Invoke(CreateTableSheetOperationQueuedResponse!);
            }
            else if (IsCreateTableSheetOperationNoopResponse)
            {
                createTableSheetOperationNoopResponse?.Invoke(CreateTableSheetOperationNoopResponse!);
            }
            else if (IsCreateTableSheetOperationConfirmationResponse)
            {
                createTableSheetOperationConfirmationResponse?.Invoke(CreateTableSheetOperationConfirmationResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateTableSheetOperationQueuedResponse,
                typeof(global::PromptLayer.CreateTableSheetOperationQueuedResponse),
                CreateTableSheetOperationNoopResponse,
                typeof(global::PromptLayer.CreateTableSheetOperationNoopResponse),
                CreateTableSheetOperationConfirmationResponse,
                typeof(global::PromptLayer.CreateTableSheetOperationConfirmationResponse),
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
        public bool Equals(CreateTableSheetOperationResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.CreateTableSheetOperationQueuedResponse?>.Default.Equals(CreateTableSheetOperationQueuedResponse, other.CreateTableSheetOperationQueuedResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.CreateTableSheetOperationNoopResponse?>.Default.Equals(CreateTableSheetOperationNoopResponse, other.CreateTableSheetOperationNoopResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.CreateTableSheetOperationConfirmationResponse?>.Default.Equals(CreateTableSheetOperationConfirmationResponse, other.CreateTableSheetOperationConfirmationResponse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateTableSheetOperationResponse obj1, CreateTableSheetOperationResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTableSheetOperationResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateTableSheetOperationResponse obj1, CreateTableSheetOperationResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTableSheetOperationResponse o && Equals(o);
        }
    }
}
