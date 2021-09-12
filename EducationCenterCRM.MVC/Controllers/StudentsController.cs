using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL;
using EducationCenterCRM.MVC.Models;
using EducationCenterCRM.Services;

namespace EducationCenterCRM.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentsService;
        private readonly IMapper _mapper;
        public StudentsController(IStudentService studentService, IMapper mapper)
        {
            _studentsService = studentService;
            _mapper = mapper;
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
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit";
            ViewBag.Action = "Edit";
            var student = _studentsService.GetById(id);
            return View(_mapper.Map<StudentModel>(student));
        }

        [HttpPost]
        public IActionResult Edit(StudentModel studentModel)
        {
            ViewBag.Title = "Edit student";
            ViewBag.Action = "Edit";
            
            if (ModelState.IsValid)
            {
                _studentsService.Update(_mapper.Map<Student>(studentModel));
                return View("Details",studentModel);
            }
            else
            {
                return View(studentModel);
            }

        }
        [HttpGet]
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

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Create new student";
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


    }
}
