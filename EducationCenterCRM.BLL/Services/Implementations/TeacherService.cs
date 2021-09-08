﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.DAL;
using EducationCenterCRM.Services.Interfaces;

namespace EducationCenterCRM.BLL
{

    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> _repository;

        public TeacherService(IRepository<Teacher> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            var allTeachers = await _repository.GetAllAsync();
            return allTeachers.AsEnumerable();
        }


        public Teacher GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public void Create(Teacher teacher)
        {
            _repository.Create(teacher);
        }

        public void Update(Teacher teacher)
        {
            _repository.Update(teacher);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}

