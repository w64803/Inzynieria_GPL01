using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Owners.Dto
{

    [AutoMapFrom(typeof(Owner))]
    public class OwnersDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}