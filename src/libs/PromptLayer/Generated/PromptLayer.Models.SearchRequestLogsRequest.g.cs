#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace PromptLayer
{
    /// <summary>
    /// Search and filter request logs with structured filters, free-text search, sorting, and pagination. Extends `RequestLogQuery` with pagination and `include_prompt_name`.
    /// </summary>
    public readonly partial struct SearchRequestLogsRequest : global::System.IEquatable<SearchRequestLogsRequest>
    {
        /// <summary>
        /// Canonical request-log query payload — the filter / search / sort fields shared by `POST /api/public/v2/requests/search` (which also accepts pagination + `include_prompt_name`) and `POST /api/public/v2/requests/analytics`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.RequestLogQuery? RequestLogQuery { get; init; }
#else
        public global::PromptLayer.RequestLogQuery? RequestLogQuery { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestLogQuery))]
#endif
        public bool IsRequestLogQuery => RequestLogQuery != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRequestLogQuery(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.RequestLogQuery? value)
        {
            value = RequestLogQuery;
            return IsRequestLogQuery;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::PromptLayer.SearchRequestLogsRequestVariant2? SearchRequestLogsRequestVariant2 { get; init; }
#else
        public global::PromptLayer.SearchRequestLogsRequestVariant2? SearchRequestLogsRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchRequestLogsRequestVariant2))]
#endif
        public bool IsSearchRequestLogsRequestVariant2 => SearchRequestLogsRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchRequestLogsRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::PromptLayer.SearchRequestLogsRequestVariant2? value)
        {
            value = SearchRequestLogsRequestVariant2;
            return IsSearchRequestLogsRequestVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchRequestLogsRequest(global::PromptLayer.RequestLogQuery value) => new SearchRequestLogsRequest((global::PromptLayer.RequestLogQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.RequestLogQuery?(SearchRequestLogsRequest @this) => @this.RequestLogQuery;

        /// <summary>
        /// 
        /// </summary>
        public SearchRequestLogsRequest(global::PromptLayer.RequestLogQuery? value)
        {
            RequestLogQuery = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchRequestLogsRequest(global::PromptLayer.SearchRequestLogsRequestVariant2 value) => new SearchRequestLogsRequest((global::PromptLayer.SearchRequestLogsRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::PromptLayer.SearchRequestLogsRequestVariant2?(SearchRequestLogsRequest @this) => @this.SearchRequestLogsRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SearchRequestLogsRequest(global::PromptLayer.SearchRequestLogsRequestVariant2? value)
        {
            SearchRequestLogsRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchRequestLogsRequest(
            global::PromptLayer.RequestLogQuery? requestLogQuery,
            global::PromptLayer.SearchRequestLogsRequestVariant2? searchRequestLogsRequestVariant2
            )
        {
            RequestLogQuery = requestLogQuery;
            SearchRequestLogsRequestVariant2 = searchRequestLogsRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchRequestLogsRequestVariant2 as object ??
            RequestLogQuery as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RequestLogQuery?.ToString() ??
            SearchRequestLogsRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRequestLogQuery && IsSearchRequestLogsRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::PromptLayer.RequestLogQuery, TResult>? requestLogQuery = null,
            global::System.Func<global::PromptLayer.SearchRequestLogsRequestVariant2, TResult>? searchRequestLogsRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestLogQuery && requestLogQuery != null)
            {
                return requestLogQuery(RequestLogQuery!);
            }
            else if (IsSearchRequestLogsRequestVariant2 && searchRequestLogsRequestVariant2 != null)
            {
                return searchRequestLogsRequestVariant2(SearchRequestLogsRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::PromptLayer.RequestLogQuery>? requestLogQuery = null,

            global::System.Action<global::PromptLayer.SearchRequestLogsRequestVariant2>? searchRequestLogsRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestLogQuery)
            {
                requestLogQuery?.Invoke(RequestLogQuery!);
            }
            else if (IsSearchRequestLogsRequestVariant2)
            {
                searchRequestLogsRequestVariant2?.Invoke(SearchRequestLogsRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::PromptLayer.RequestLogQuery>? requestLogQuery = null,
            global::System.Action<global::PromptLayer.SearchRequestLogsRequestVariant2>? searchRequestLogsRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestLogQuery)
            {
                requestLogQuery?.Invoke(RequestLogQuery!);
            }
            else if (IsSearchRequestLogsRequestVariant2)
            {
                searchRequestLogsRequestVariant2?.Invoke(SearchRequestLogsRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RequestLogQuery,
                typeof(global::PromptLayer.RequestLogQuery),
                SearchRequestLogsRequestVariant2,
                typeof(global::PromptLayer.SearchRequestLogsRequestVariant2),
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
        public bool Equals(SearchRequestLogsRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.RequestLogQuery?>.Default.Equals(RequestLogQuery, other.RequestLogQuery) &&
                global::System.Collections.Generic.EqualityComparer<global::PromptLayer.SearchRequestLogsRequestVariant2?>.Default.Equals(SearchRequestLogsRequestVariant2, other.SearchRequestLogsRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchRequestLogsRequest obj1, SearchRequestLogsRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchRequestLogsRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchRequestLogsRequest obj1, SearchRequestLogsRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchRequestLogsRequest o && Equals(o);
        }
    }
}
