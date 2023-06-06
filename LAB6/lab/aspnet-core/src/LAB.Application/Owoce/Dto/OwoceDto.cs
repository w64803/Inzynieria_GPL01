using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Owoce.Dto
{

    [AutoMapFrom(typeof(OwoceDto))]
    public class OwoceDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}



