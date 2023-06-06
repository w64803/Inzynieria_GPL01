using Abp.Application.Services;
using Abp.Domain.Repositories;
using LAB.Cars.Dto;

namespace LAB.Cars
{

    public class CarAppService : AsyncCrudAppService<Car, CarDto, long, PagedCarResultRequestDto, CarDto, CarDto>, ICarAppService
    {
        public CarAppService(IRepository<Car, long> repository) : base(repository)
        {
        }
    }
}