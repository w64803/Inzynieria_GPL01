using Abp.Application.Services.Dto;

namespace LAB.Cars.Dto
{
    public class PagedCarResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

