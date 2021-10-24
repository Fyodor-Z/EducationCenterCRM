using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.Api.Dto;
using EducationCenterCRM.BLL.Models;

namespace EducationCenterCRM.Api.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Course, CourseDto>()
                .ForMember(model => model.TopicName, map => map.MapFrom(c => c.Topic.Title))
                .ReverseMap();
        }
    }
}
