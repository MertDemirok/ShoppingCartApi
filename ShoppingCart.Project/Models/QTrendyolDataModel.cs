using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShoppingCart.Project.Models
{

    public partial class TrendData
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("headers")]
        public Headers Headers { get; set; }
    }

    public partial class Headers
    {
    }

    public partial class Result
    {
        [JsonProperty("aggregations")]
        public List<Aggregation> Aggregations { get; set; }

        [JsonProperty("resolvedQuery")]
        public ResolvedQuery ResolvedQuery { get; set; }

        [JsonProperty("categoryGenealogyNodes")]
        public List<object> CategoryGenealogyNodes { get; set; }
    }

    public partial class Aggregation
    {
        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("filterKey")]
        public string FilterKey { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("totalCount")]
        public long TotalCount { get; set; }

        [JsonProperty("values")]
        public List<Value> Values { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("filterField")]
        public string FilterField { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("beautifiedName", NullValueHandling = NullValueHandling.Ignore)]
        public string BeautifiedName { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("filtered")]
        public bool Filtered { get; set; }
    }

    public partial class ResolvedQuery
    {
        [JsonProperty("filters")]
        public List<ResolvedQueryFilter> Filters { get; set; }

        [JsonProperty("alternateFilters")]
        public List<object> AlternateFilters { get; set; }
    }

    public partial class ResolvedQueryFilter
    {
        [JsonProperty("filterKey")]
        public string FilterKey { get; set; }

        [JsonProperty("filterType")]
        public string FilterType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("filterField")]
        public string FilterField { get; set; }

        [JsonProperty("values")]
        public List<long> Values { get; set; }

        [JsonProperty("filters")]
        public List<FilterFilter> Filters { get; set; }
    }

    public partial class FilterFilter
    {
        [JsonProperty("key")]
        public long Key { get; set; }

        [JsonProperty("beautifiedName")]
        public string BeautifiedName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
