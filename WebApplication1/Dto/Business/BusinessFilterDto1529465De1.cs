using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;

namespace WebApplication1.Dtos
{
    public class BusinessFilterDto1529465De1 : FilterDto1529465De1
    {
        [FromQuery(Name = "Name")]
        public string? Name { get; set; }
        [FromQuery(Name = "TaxId")]
        public string? TaxId { get; set; }
    }
}
