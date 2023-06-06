using Abp.Application.Services.Dto;

namespace LAB.Owoce.Dto
{
    public class PagedOwoceResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

