using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.MVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace EducationCenterCRM.MVC.Controllers
{
    public class StudentRequestsController : Controller
    {
        private readonly IStudentRequestService _studentRequestService;
        private readonly IEntityService<Course> _courseService;
        private readonly IMapper _mapper;
        public StudentRequestsController(IStudentRequestService studentRequestService, IEntityService<Course> courseService, IMapper mapper)
        {
            _studentRequestService = studentRequestService;
            _courseService = courseService;
            _mapper = mapper;
        }


        //public async Task<IActionResult> Index()
        //{
        //    var studentRequests = await _studentRequestService.GetAllAsync();
        //    return View(_mapper.Map<IEnumerable<StudentRequestModel>>(studentRequests));
        //}

        [Authorize(Roles = "admin, manager")]
        public IActionResult Details(Guid id)
        {
            var studentRequest = _studentRequestService.GetById(id);
            return View(_mapper.Map<StudentRequestModel>(studentRequest));
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            var courses = _courseService.GetAll();
            ViewBag.Courses = _mapper.Map<IEnumerable<CourseModel>>(courses);
            return View("Create", new StudentRequestModel());
        }

        [HttpPost]
        public IActionResult Create(StudentRequestModel studentRequestModel)
        {
            if (ModelState.IsValid)
            {
                var studentRequest = _studentRequestService.Create(_mapper.Map<StudentRequest>(studentRequestModel));
                return View("ConfirmRequest", _mapper.Map<StudentRequestModel>(studentRequest));
            }
            else
            {
                return View("Create");
            }
        }


    }
}

