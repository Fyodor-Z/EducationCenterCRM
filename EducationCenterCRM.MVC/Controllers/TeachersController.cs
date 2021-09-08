﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.Services.Interfaces;
using EducationCenterCRM.BLL;

namespace EducationCenterCRM.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;
        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        //public IActionResult Index()
        //{
        //    var teachers = _teacherService.GetAll();
        //    return View(teachers);
        //}

        public async Task<IActionResult> Index()
        {
            var teachers = await _teacherService.GetAllAsync();
            return View(teachers);
        }

        public IActionResult Details(Guid id)
        {
            var teacher = _teacherService.GetById(id);
            return View(teacher);
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            ViewBag.Title = "Edit";
            ViewBag.Action = "Edit";
            var teacher = _teacherService.GetById(id);
            return View(teacher);
        }

        [HttpPost]
        public IActionResult Edit(TeacherModel teacher)
        {
            ViewBag.Title = "Edit teacher";
            ViewBag.Action = "Edit";
            var id = teacher.Id;
            var teacherToUpdate = _teacherService.GetById(id);
            if (ModelState.IsValid)
            {
                teacherToUpdate.Bio = teacher.Bio;
                teacherToUpdate.LinkToProfile = teacher.LinkToProfile;
                teacherToUpdate.Gender = teacher.Gender;
                teacherToUpdate.BirthDate = teacher.BirthDate;
                teacherToUpdate.FirstName = teacher.FirstName;
                teacherToUpdate.LastName = teacher.LastName;

                _teacherService.Update(teacherToUpdate);
                return View(teacherToUpdate);
            }
            else
            {
                return View(teacherToUpdate);
            }

        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var teacher = _teacherService.GetById(id);
            return View(teacher);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            _teacherService.Delete(id);
            var teachers = _teacherService.GetAll();
            return View("Index", teachers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            ViewBag.Title = "Add new teacher";
            return View("Edit", new TeacherModel());
        }

        [HttpPost]
        public IActionResult Create(TeacherModel teacher)
        {
            ViewBag.Title = "Add new teacher";
            ViewBag.Action = "Create";
            if (ModelState.IsValid)
            {
                _teacherService.Create(teacher);
                return View("Details", teacher);
            }
            else
            {
                return View("Edit");
            }
        }
    }
}
