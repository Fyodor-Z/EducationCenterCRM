using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.BLL.Services.Impl
{
    public class StudentRequestService : IStudentRequestService
    {
        private readonly IRepository<StudentRequest> _repository;

        public StudentRequestService(IRepository<StudentRequest> repository)
        {
            _repository = repository;
        }

        public IEnumerable<StudentRequest> GetAll()
        {
            return _repository.GetAll();
        }
        public async Task<IEnumerable<StudentRequest>> GetAllAsync()
        {
            var allStudentRequests = await _repository.GetAllAsync();
            return allStudentRequests.AsEnumerable();
        }

        public StudentRequest GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public StudentRequest Create(StudentRequest studentRequest)
        {
            return _repository.Create(studentRequest);
        }

        public StudentRequest Update(StudentRequest studentRequest)
        {
            return _repository.Update(studentRequest);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public StudentRequest ChangeStatus(Guid id)
        {
            var studentRequest = _repository.Get(id);
            if (studentRequest.Status == RequestStatus.Processed)
            {
                studentRequest.Status = RequestStatus.Unprocessed;
            }
            else
            {
                studentRequest.Status = RequestStatus.Processed;
            }

            return _repository.Update(studentRequest);
        }
    }
}
