using Abp.Application.Services;
using LAB.MultiTenancy.Dto;

namespace LAB.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

