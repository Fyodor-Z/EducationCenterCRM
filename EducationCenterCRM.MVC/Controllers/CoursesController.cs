using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.MVC.Models;

namespace EducationCenterCRM.MVC.Controllers
{
    public class CoursesController : Controller
    {
        private readonly IEntityService<Course> _courseService;
        private readonly IEntityService<StudentGroup> _studentGroupService;
        private readonly IMapper _mapper;
        public CoursesController(IEntityService<Course> courseService, IEntityService<StudentGroup> studentGroupService, IMapper mapper)
        {
            _courseService = courseService;
            _studentGroupService = studentGroupService;
            _mapper = mapper;
        }

        
        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<CourseModel>>(courses));
        }
    }
}
