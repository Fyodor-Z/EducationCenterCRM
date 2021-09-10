﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.Services.Interfaces;
using EducationCenterCRM.BLL;
using EducationCenterCRM.MVC.Models;

namespace EducationCenterCRM.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;
        public TeachersController(ITeacherService teacherService, IMapper mapper)
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
                _teacherService.Update(_mapper.Map<Teacher>(teacherModel));
                return View(teacherModel);
            }
            else
            {
                return View(teacherModel);
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
                _teacherService.Create(_mapper.Map<Teacher>(teacherModel));
                return View("Details", teacherModel);
            }
            else
            {
                return View("Edit");
            }
        }
    }
}
