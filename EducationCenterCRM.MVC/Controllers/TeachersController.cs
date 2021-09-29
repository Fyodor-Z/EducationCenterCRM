using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenterCRM.MVC.Controllers
{
    public class TeachersController : Controller
    {
        private readonly IEntityService<Teacher> _teacherService;
        private readonly IMapper _mapper;
        public TeachersController(IEntityService<Teacher> teacherService, IMapper mapper)
        {
            _teacherService = teacherService;
            _mapper = mapper;
        }
       

        public async Task<IActionResult> Index()
        {
            var teachers = await _teacherService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<TeacherModel>>(teachers));
        }

        public IActionResult Details(Guid id)
        {
            var teacher = _teacherService.GetById(id);
            return View(_mapper.Map<TeacherModel>(teacher));
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit";
            ViewBag.Action = "Edit";
            var teacher = _teacherService.GetById(id);
            return View(_mapper.Map<TeacherModel>(teacher));
        }

        [HttpPost]
        public IActionResult Edit(TeacherModel teacherModel)
        {
            ViewBag.Title = "Edit teacher";
            ViewBag.Action = "Edit";
            if (ModelState.IsValid)
            {
                var teacher = _teacherService.Update(_mapper.Map<Teacher>(teacherModel));
                return View("Details", _mapper.Map<TeacherModel>(teacher));
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var teacher = _teacherService.GetById(id);
            return View(_mapper.Map<TeacherModel>(teacher));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            _teacherService.Delete(id);
            var teachers = _teacherService.GetAll();
            return View("Index", _mapper.Map<IEnumerable<TeacherModel>>(teachers));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Add new teacher";
            return View("Edit", new TeacherModel());
        }

        [HttpPost]
        public IActionResult Create(TeacherModel teacherModel)
        {
            ViewBag.Title = "Add new teacher";
            ViewBag.Action = "Create";
            if (ModelState.IsValid)
            {
                var teacher = _teacherService.Create(_mapper.Map<Teacher>(teacherModel));
                return View("Details", _mapper.Map<TeacherModel>(teacher));
            }
            else
            {
                return View("Edit");
            }
        }
    }
}
