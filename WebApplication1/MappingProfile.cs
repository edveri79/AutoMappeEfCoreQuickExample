using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApplication1.Entities;

namespace WebApplication1
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ContactEntity, WebApplication1.DTO.ContactDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Firstname + ' ' + src.Lastname));
        }
    }
}
