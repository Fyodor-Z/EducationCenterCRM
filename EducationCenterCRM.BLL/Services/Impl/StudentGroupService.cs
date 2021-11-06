using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.DAL;
using ClosedXML.Excel;

namespace EducationCenterCRM.BLL.Services.Impl
{
    public class StudentGroupService : IStudentGroupService
    {

        private readonly IRepository<StudentGroup> _repository;

        public StudentGroupService(IRepository<StudentGroup> repository)
        {
            _repository = repository;
        }

        public IEnumerable<StudentGroup> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<StudentGroup>> GetAllAsync()
        {
            var allStudents = await _repository.GetAllAsync();
            return allStudents.AsEnumerable();
        }

        public StudentGroup GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public StudentGroup Create(StudentGroup group)
        {
            _repository.Create(group);
            return group;
        }

        public StudentGroup Update(StudentGroup group)
        {
            _repository.Update(group);
            return group;
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public byte[] ExportGroupMarks(Guid id, out string fileName)
        {
            var studentGroup = GetById(id);

            fileName = studentGroup.Title + "_marks_" + DateTime.Today.ToShortDateString() + ".xlsx";

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Users");
                var currentRow = 1;
                var currentColumn = 1;
                worksheet.Cell(currentRow, currentColumn).Value = "Student";
                currentColumn++;
                foreach (var lesson in studentGroup.Lessons.OrderBy(l => l.LessonDate))
                {
                    worksheet.Cell(currentRow, currentColumn).Value = lesson.LessonDate.ToShortDateString();
                    currentColumn++;
                }

                currentRow++;

                foreach (var student in studentGroup.Students)
                {
                    currentColumn = 1;
                    worksheet.Cell(currentRow, currentColumn).Value = string.Join(" ", student.FirstName, student.LastName);
                    currentColumn++;
                    foreach (var lesson in studentGroup.Lessons.OrderBy(l => l.LessonDate))
                    {
                        var studentScoreForLesson = -1;
                        foreach (var mark in student.Marks)
                        {
                            if (mark.LessonId == lesson.Id)
                            {
                                studentScoreForLesson = mark.Score;
                                break;
                            }
                        }
                        if (studentScoreForLesson != -1)
                        {
                            worksheet.Cell(currentRow, currentColumn).Value = studentScoreForLesson;
                        }

                        currentColumn++;
                    }
                   
                    currentRow++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray(); ;
                }
            }

        }
    }
}