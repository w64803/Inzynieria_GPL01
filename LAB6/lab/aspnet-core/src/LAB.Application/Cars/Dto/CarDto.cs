using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Cars.Dto
{

    [AutoMapFrom(typeof(Car))]
    public class CarDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}