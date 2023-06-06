using Abp.Application.Services;
using Abp.Domain.Repositories;
using LAB.Owners.Dto;

namespace LAB.Owners
{

    public class OwnersAppService : AsyncCrudAppService<Owner, OwnersDto, long, PagedOwnersResultRequestDto, OwnersDto, OwnersDto>, IOwnersAppService
    {
        public OwnersAppService(IRepository<Owner, long> repository) : base(repository)
        {
        }
    }
}