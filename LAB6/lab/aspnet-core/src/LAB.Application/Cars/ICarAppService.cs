using Abp.Application.Services;
using LAB.Cars.Dto;

namespace LAB.Cars
{

    public interface ICarAppService : IAsyncCrudAppService<CarDto, long, PagedCarResultRequestDto, CarDto, CarDto>
    {

    }
}