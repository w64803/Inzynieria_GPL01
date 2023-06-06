using Abp.Application.Services.Dto;

namespace LAB.Owners.Dto
{
    public class PagedOwnersResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

