using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Model.Dto;
using TCECPortal_API.Models;

namespace TCECPortal_API.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
