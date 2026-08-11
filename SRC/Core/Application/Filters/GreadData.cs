using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Filters
{
    public class GreadData<T> where T : class,new()
    {
        public IEnumerable<T>? Data { get; set; }
        public T? Entity { get; set; }

        public List<Filter> Filter { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int PageCount { get; set; } = 1;
        public int Count { get; set; } = 0;

    }

    public class Filter
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }
}
