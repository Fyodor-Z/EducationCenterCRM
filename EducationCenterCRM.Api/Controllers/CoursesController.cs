using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.Api.Dto;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services;
using EducationCenterCRM.BLL.Services.Interfaces;

namespace EducationCenterCRM.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IEntityService<Course> _service;
        private readonly IMapper _mapper;

        public CoursesController(IEntityService<Course> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<CourseDto> Get()
        {
            return _mapper.Map<IEnumerable<CourseDto>>(_service.GetAll());
        }

        [HttpGet("async")]
        public async Task<IEnumerable<CourseDto>> GetAsync()
        {
            return _mapper.Map<IEnumerable<CourseDto>>(await _service.GetAllAsync());
        }
    }
}
