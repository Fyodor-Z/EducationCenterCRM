using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL;
using EducationCenterCRM.MVC.Models;

namespace EducationCenterCRM.MVC.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonModel>()
                .ReverseMap();
            CreateMap<Teacher, TeacherModel>()
                .ReverseMap();
            CreateMap<Student, StudentModel>()
                .ReverseMap();
        }
    }
}
