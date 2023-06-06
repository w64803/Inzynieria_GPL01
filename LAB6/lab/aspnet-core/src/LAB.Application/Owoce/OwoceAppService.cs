using Abp.Application.Services;
using Abp.Domain.Repositories;
using LAB.Owoce.Dto;

namespace LAB.Owoce
{

    public class OwoceAppService : AsyncCrudAppService<OwoceDto, Owoc, long, PagedOwoceResultRequestDto, OwoceDto, OwoceDto>, IOwoceAppService
    {
        public OwoceAppService(IRepository<Owoc, long> repository) : base(repository)
        {
        }
    }
}