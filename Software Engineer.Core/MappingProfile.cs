using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_Engineer.Core.DTOs;
using Software_Engineer.Core.Entities;
using AutoMapper;

namespace Software_Engineer.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AchievementsDto, Achievements>().ReverseMap();
            CreateMap<ProjectsDto, Projects>().ReverseMap();
            CreateMap<OfficesDto, Office>().ReverseMap();

        }
    }
}
