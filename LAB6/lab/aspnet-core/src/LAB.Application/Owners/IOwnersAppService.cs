using Abp.Application.Services;
using LAB.Owners.Dto;

namespace LAB.Owners
{

    public interface IOwnersAppService : IAsyncCrudAppService<OwnersDto, long, PagedOwnersResultRequestDto, OwnersDto, OwnersDto>
    {

    }
}