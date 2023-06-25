using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApplication1.Dto
{
    public class FilterDto1529465De1
    {
        private string _keyword;

        [FromQuery(Name = "keyword")]
        public string Keyword
        {
            get => _keyword;
            set => _keyword = value?.Trim();
        }

        [FromQuery(Name = "pageSize")]
        public int PageSize { get; set; }

        [FromQuery(Name = "pageIndex")]
        public int PageIndex { get; set; }

        public int Skip()
        {
            return (PageIndex - 1) * PageSize;
        }

    }
}
