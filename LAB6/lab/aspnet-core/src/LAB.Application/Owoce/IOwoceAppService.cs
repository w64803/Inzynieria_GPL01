using Abp.Application.Services;
using LAB.Owoce.Dto;

namespace LAB.Owoce
{

    public interface IOwoceAppService : IAsyncCrudAppService<OwoceDto, long, PagedOwoceResultRequestDto, OwoceDto, OwoceDto>
    {

    }
}