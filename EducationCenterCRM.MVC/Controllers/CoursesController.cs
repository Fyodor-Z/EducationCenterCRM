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
        private readonly IEntityService<Topic> _topicService;
        private readonly IMapper _mapper;
        public CoursesController(IEntityService<Course> courseService, IEntityService<Topic> topicService, IMapper mapper)
        {
            _courseService = courseService;
            _topicService = topicService;
            _mapper = mapper;
        }

        
        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<CourseModel>>(courses));
        }

        public IActionResult Details(Guid id)
        {
            var course = _courseService.GetById(id);
            return View(_mapper.Map<CourseModel>(course));
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var course = _courseService.GetById(id);
            return View(_mapper.Map<CourseModel>(course));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            _courseService.Delete(id);
            var courses = _courseService.GetAll();
            return View("Index", _mapper.Map<IEnumerable<CourseModel>>(courses));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Create new course";
            var topics = _topicService.GetAll();
            ViewBag.Teachers = _mapper.Map<IEnumerable<TopicModel>>(topics);
            return View("Edit", new CourseModel());
        }

        [HttpPost]
        public IActionResult Create(CourseModel courseModel)
        {
            ViewBag.Title = "Create new course";
            ViewBag.Action = "Create";
            if (ModelState.IsValid)
            {
                var course = _courseService.Create(_mapper.Map<Course>(courseModel));
                return View("Details", _mapper.Map<CourseModel>(course));
            }
            else
            {
                return View("Edit");
            }
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit course";
            ViewBag.Action = "Edit";
            var topics = _topicService.GetAll();
            ViewBag.Topics = _mapper.Map<IEnumerable<TopicModel>>(topics);
            var course = _courseService.GetById(id);
            return View(_mapper.Map<CourseModel>(course));
        }

        [HttpPost]
        public IActionResult Edit(CourseModel courseModel)
        {
            ViewBag.Title = "Edit course";
            ViewBag.Action = "Edit";

            if (ModelState.IsValid)
            {
                var course = _courseService.Update(_mapper.Map<Course>(courseModel));
                return View("Details", _mapper.Map<CourseModel>(course));
            }
            else
            {
                return View();
            }

        }
    }
}
