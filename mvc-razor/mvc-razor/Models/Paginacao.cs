using System;
using System.Collections.Generic;

namespace mvc_razor.Models
{
    public class Paginacao<T>
    {
        public List<T> Results { get; set; }

        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int RecordCount { get; set; }
    }
}
