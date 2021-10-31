using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Impl;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.MVC.Models;

namespace EducationCenterCRM.MVC.Controllers
{
    public class MarksController : Controller
    {
        private readonly IEntityService<Mark> _markService;
        private readonly IEntityService<Lesson> _lessonService;
        private readonly IEntityService<StudentGroup> _groupService;
        private readonly IMapper _mapper;
        public MarksController(IEntityService<Lesson> lessonService, IEntityService<StudentGroup> groupService, IEntityService<Mark> markService,IMapper mapper)
        {
            _markService = markService;
            _lessonService = lessonService;
            _groupService = groupService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AddMarkToLesson(Guid lessonId)
        {
            var lesson = _lessonService.GetById(lessonId);
            //all students of a group
            var groupStudents = lesson.Group.Students;
            //students who already have mark for a lesson
            var studentsWithMarks = lesson.Marks.Select(m => m.Student);
            var students = groupStudents.Except(studentsWithMarks);
            var markModel = new MarkModel() { LessonId = lessonId, Lesson = _mapper.Map<LessonModel>(lesson), Score = 7 };
            if (students.Any())
            {
                ViewBag.Students = _mapper.Map<IEnumerable<StudentModel>>(students);
                return View(markModel);
            }
            else
            {
                return View("ErrorMarks", markModel);
            }
            
        }
        [HttpPost]
        public IActionResult AddMarkToLesson(MarkModel markModel)
        {
            if (ModelState.IsValid)
            {
                var mark = _markService.Create(_mapper.Map<Mark>(markModel));
                var lesson = mark.Lesson;
                return View("~/Views/Lessons/Edit.cshtml", _mapper.Map<LessonModel>(lesson));
            }
            else
            {
                return View();
            }
        }
    }
}
