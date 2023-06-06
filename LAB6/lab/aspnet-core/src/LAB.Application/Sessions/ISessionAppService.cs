using System.Threading.Tasks;
using Abp.Application.Services;
using LAB.Sessions.Dto;

namespace LAB.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
