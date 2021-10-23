using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.BLL.Services.Impl
{
    public class CourseService: IEntityService<Course>
    {

        private readonly IRepository<Course> _repository;

        public CourseService(IRepository<Course> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Course> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            var allCourses = await _repository.GetAllAsync();
            return allCourses.AsEnumerable();
        }

        public Course GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public Course Create(Course group)
        {
            _repository.Create(group);
            return group;
        }

        public Course Update(Course group)
        {
            _repository.Update(group);
            return group;
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
