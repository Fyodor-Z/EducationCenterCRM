using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services;
using EducationCenterCRM.MVC.Models;

namespace EducationCenterCRM.MVC.Controllers
{
    public class StudentGroupsController : Controller
    {
        private readonly IStudentGroupService _studentGroupService;
        private readonly IMapper _mapper;
        public StudentGroupsController(IStudentGroupService studentGroupService, IMapper mapper)
        {
            _studentGroupService = studentGroupService;
            _mapper = mapper;
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
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit group";
            ViewBag.Action = "Edit";
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
                _studentGroupService.Update(_mapper.Map<StudentGroup>(groupModel));
                return View("Details", groupModel);
            }
            else
            {
                return View(groupModel);
            }

        }
        [HttpGet]
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
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Create new group";
            return View("Edit", new StudentGroupModel());
        }

        [HttpPost]
        public IActionResult Create(StudentGroupModel studentGroupModel)
        {
            ViewBag.Title = "Create new student";
            ViewBag.Action = "Create";
            if (ModelState.IsValid)
            {
                var group = _studentGroupService.Create(_mapper.Map<StudentGroup>(studentGroupModel));
                return View("Details", _mapper.Map<StudentModel>(group));
            }
            else
            {
                return View("Edit");
            }
        }


    }
}
