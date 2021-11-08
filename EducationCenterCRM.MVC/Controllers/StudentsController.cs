using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services;
using EducationCenterCRM.BLL.Services.Impl;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenterCRM.MVC.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly IEntityService<Student> _studentsService;
        private readonly IMapper _mapper;
        private readonly IStudentGroupService _studentGroupService;
        private readonly IStudentRequestService _studentRequestService;
        public StudentsController(IEntityService<Student> studentService, IMapper mapper, IStudentGroupService studentGroupService, IStudentRequestService studentRequestService)
        {
            _studentsService = studentService;
            _mapper = mapper;
            _studentGroupService = studentGroupService;
            _studentRequestService = studentRequestService;
        }
        
        public async Task<IActionResult> Index()
        {
            var students = await _studentsService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<StudentModel>>(students));
        }


        public IActionResult Details(Guid id)
        {
            var student = _studentsService.GetById(id);
            return View(_mapper.Map<StudentModel>(student));
        }
        [HttpGet]
        [Authorize(Roles = "admin, manager")]
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit";
            ViewBag.Action = "Edit";
            var student = _studentsService.GetById(id);
            var groups = _studentGroupService.GetAll().OrderBy(g => g.Title);
            ViewBag.Groups = _mapper.Map<IEnumerable<StudentGroupModel>>(groups);
            return View(_mapper.Map<StudentModel>(student));
        }

        [HttpPost]
        public IActionResult Edit(StudentModel studentModel)
        {
            ViewBag.Title = "Edit student";
            ViewBag.Action = "Edit";
            
            if (ModelState.IsValid)
            {
                var student =_studentsService.Update(_mapper.Map<Student>(studentModel));
                return View("Details",_mapper.Map<StudentModel>(student));
            }
            else
            {
                return View();
            }

        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(Guid id)
        {
            var student = _studentsService.GetById(id);
            return View(_mapper.Map<StudentModel>(student));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            _studentsService.Delete(id);
            var students = _studentsService.GetAll();
            return View("Index", _mapper.Map<IEnumerable<StudentModel>>(students));
        }

        [Authorize(Roles = "admin, manager")]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Create new student";
            var groups = _studentGroupService.GetAll().OrderBy(g => g.Title);
            ViewBag.Groups = _mapper.Map<IEnumerable<StudentGroupModel>>(groups);
            return View("Edit", new StudentModel());
        }

        [HttpPost]
        public IActionResult Create(StudentModel studentModel)
        {
            ViewBag.Title = "Create new student";
            ViewBag.Action = "Create";
            if (ModelState.IsValid)
            {
                var student =_studentsService.Create(_mapper.Map<Student>(studentModel));
                return View("Details", _mapper.Map<StudentModel>(student));
            }
            else
            {
                return View("Edit");
            }
        }


        [Authorize(Roles = "admin, manager")]
        [HttpGet]
        public IActionResult CreateFromRequest(Guid id)
        {
            var studentRequest = _studentRequestService.GetById(id);
            
            ViewBag.Action = "Create";
            ViewBag.Title = "Create new student from request";
            
            var studentModel = new StudentModel()
            {
                Id = Guid.Empty,
                FirstName = studentRequest.FirstName,
                LastName = studentRequest.LastName,
                Email = studentRequest.Email,
                Phone = studentRequest.Phone
            };

            var groups = _studentGroupService.GetAll()
                .Where(s => s.CourseId == studentRequest.CourseId)
                .OrderBy(g => g.Title);
            ViewBag.Groups = _mapper.Map<IEnumerable<StudentGroupModel>>(groups);
            return View("Edit", studentModel);
        }

    }
}
