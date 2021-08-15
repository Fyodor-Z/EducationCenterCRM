using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.Models;

namespace EducationCenterCRM.Controllers
{
    public class  StudentsController: Controller
    {
        public IActionResult Index()
        {
            return View(StudentList.Students);
        }

        public IActionResult Details(int id)
        {
            Student student = StudentList.GetStudentById(id);
            return View(student);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Edit";
            ViewBag.Action = "Edit";
            Student student = StudentList.GetStudentById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            ViewBag.Title = "Edit student";
            ViewBag.Action = "Edit";
            if (ModelState.IsValid)
            {
                StudentList.UpdateStudent(student);
                return View(student);
            }
            else
            {
                return View(student);
            }
           
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student student = StudentList.GetStudentById(id);
            return View(student);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            Student student = StudentList.GetStudentById(id);
            StudentList.DeleteStudent(student);
            return View("Index", StudentList.Students);
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
                StudentList.CreateStudent(student);
                return View("Details", student);
            }
            else
            {
                return View("Edit");
            }
        }


    }
}
