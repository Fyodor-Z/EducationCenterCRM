using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.Models;
using EducationCenterCRM.Services;

namespace EducationCenterCRM.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentsService;
        public StudentsController(IStudentService studentService)
        {
            _studentsService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentsService.GetAll();
            return View(students);
        }

        public IActionResult Details(Guid id)
        {
            var student = _studentsService.GetById(id);
            return View(student);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit";
            ViewBag.Action = "Edit";
            var student = _studentsService.GetById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            ViewBag.Title = "Edit student";
            ViewBag.Action = "Edit";
            if (ModelState.IsValid)
            {
                _studentsService.Update(student);
                return View(student);
            }
            else
            {
                return View(student);
            }

        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var student = _studentsService.GetById(id);
            return View(student);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            _studentsService.Delete(id);
            var students = _studentsService.GetAll();
            return View("Index", students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Create new student";
            return View("Edit", new Student());
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            ViewBag.Title = "Create new student";
            ViewBag.Action = "Create";
            if (ModelState.IsValid)
            {
                _studentsService.Create(student);
                return View("Details", student);
            }
            else
            {
                return View("Edit");
            }
        }


    }
}
