using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.MVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace EducationCenterCRM.MVC.Controllers
{
    [Authorize]
    public class StudentGroupsController : Controller
    {
        private readonly IEntityService<StudentGroup> _studentGroupService;
        private readonly IEntityService<Teacher> _teacherService;
        private readonly IMapper _mapper;
        public StudentGroupsController(IEntityService<StudentGroup> studentGroupService, IEntityService<Teacher> teacherService, IMapper mapper)
        {
            _studentGroupService = studentGroupService;
            _mapper = mapper;
            _teacherService = teacherService;
        }

        public async Task<IActionResult> Index()
        {
            var studentGroups = await _studentGroupService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<StudentGroupModel>>(studentGroups));
        }


        public IActionResult Details(Guid id)
        {
            var studentGroup = _studentGroupService.GetById(id);
            ViewBag.Students = studentGroup.Students;
            return View(_mapper.Map<StudentGroupModel>(studentGroup));
        }
        [HttpGet]
        [Authorize(Roles = "admin, manager")]
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit group";
            ViewBag.Action = "Edit";
            var teachers = _teacherService.GetAll();
            ViewBag.Teachers = _mapper.Map<IEnumerable<TeacherModel>>(teachers);
            var studentGroup = _studentGroupService.GetById(id);
            return View(_mapper.Map<StudentGroupModel>(studentGroup));
        }

        [HttpPost]
        public IActionResult Edit(StudentGroupModel groupModel)
        {
            ViewBag.Title = "Edit group";
            ViewBag.Action = "Edit";
            
            if (ModelState.IsValid)
            {
                var group = _studentGroupService.Update(_mapper.Map<StudentGroup>(groupModel));
                return View("Details", _mapper.Map<StudentGroupModel>(group));
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
            var group = _studentGroupService.GetById(id);
            return View(_mapper.Map<StudentGroupModel>(group));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            _studentGroupService.Delete(id);
            var groups = _studentGroupService.GetAll();
            return View("Index", _mapper.Map<IEnumerable<StudentGroupModel>>(groups));
        }

        [HttpGet]
        [Authorize(Roles = "admin, manager")]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Create new group";
            var teachers = _teacherService.GetAll();
            ViewBag.Teachers = _mapper.Map<IEnumerable<TeacherModel>>(teachers);
            return View("Edit", new StudentGroupModel());
        }

        [HttpPost]
        public IActionResult Create(StudentGroupModel studentGroupModel)
        {
            ViewBag.Title = "Create new group";
            ViewBag.Action = "Create";
            if (ModelState.IsValid)
            {
                var group = _studentGroupService.Create(_mapper.Map<StudentGroup>(studentGroupModel));
                return View("Details", _mapper.Map<StudentGroupModel>(group));
            }
            else
            {
                return View("Edit");
            }
        }


    }
}
