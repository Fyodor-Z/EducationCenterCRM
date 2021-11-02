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
    public class LessonsController : Controller
    {
        private readonly IEntityService<Lesson> _lessonService;
        private readonly IEntityService<StudentGroup> _groupService;
        private readonly IMapper _mapper;
        public LessonsController(IEntityService<Lesson> lessonService, IEntityService<StudentGroup> groupService, IMapper mapper)
        {
            _lessonService = lessonService;
            _groupService = groupService;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var lessons = await _lessonService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<LessonModel>>(lessons));
        }

        public IActionResult Details(Guid id)
        {
            var lesson = _lessonService.GetById(id);
            return View(_mapper.Map<LessonModel>(lesson));
        }
        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var lesson = _lessonService.GetById(id);
            return View(_mapper.Map<LessonModel>(lesson));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            _lessonService.Delete(id);
            var lessons = _lessonService.GetAll();
            return View("Index", _mapper.Map<IEnumerable<LessonModel>>(lessons));
        }
        [Authorize(Roles = "admin, manager")]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Create new lesson";
            var groups = _groupService.GetAll();
            ViewBag.Groups = _mapper.Map<IEnumerable<StudentGroupModel>>(groups);
            return View("Edit", new LessonModel());
        }

        [HttpPost]
        public IActionResult Create(LessonModel lessonModel)
        {
            ViewBag.Title = "Create new lesson";
            ViewBag.Action = "Create";
            if (ModelState.IsValid)
            {
                var lesson = _lessonService.Create(_mapper.Map<Lesson>(lessonModel));
                ViewBag.Title = "Edit lesson";
                ViewBag.Action = "Edit";
                var groups = _groupService.GetAll();
                ViewBag.Groups = _mapper.Map<IEnumerable<StudentGroupModel>>(groups);
                return View("Edit", _mapper.Map<LessonModel>(lesson));
            }
            else
            {
                return View("Edit");
            }
        }
        [Authorize(Roles = "admin, manager")]
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit lesson";
            ViewBag.Action = "Edit";
            var groups = _groupService.GetAll();
            ViewBag.Groups = _mapper.Map<IEnumerable<StudentGroupModel>>(groups);
            var lesson = _lessonService.GetById(id);
            return View(_mapper.Map<LessonModel>(lesson));
        }

        [HttpPost]
        public IActionResult Edit(LessonModel lessonModel)
        {
            ViewBag.Title = "Edit lesson";
            ViewBag.Action = "Edit";

            if (ModelState.IsValid)
            {
                var lesson = _lessonService.Update(_mapper.Map<Lesson>(lessonModel));
                return View("Details", _mapper.Map<LessonModel>(lesson));
            }
            else
            {
                return View();
            }

        }
    }
}
