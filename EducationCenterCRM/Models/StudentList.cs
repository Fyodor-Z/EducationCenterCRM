using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.Models
{
    public static class StudentList
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student(){Id = Guid.NewGuid(), FirstName = "Petr", LastName = "Ivanov", BirthDate = new DateTime(1989, 7, 20), StartDate = DateTime.Today, Gender = Gender.Male},
            new Student(){Id = Guid.NewGuid(), FirstName = "Ivan", LastName = "Petrov", BirthDate = new DateTime(1994, 8, 16), StartDate = DateTime.Today, Gender = Gender.Male},
            new Student(){Id = Guid.NewGuid(), FirstName = "Tatyana", LastName = "Usovich", BirthDate = new DateTime(1999, 1, 2), StartDate = DateTime.Today, Gender = Gender.Female}
        };

        public static IEnumerable<Student> Students
        {
            get
            {
                return _students;
            }
        }

        public static void Add(Student student)
        {
            _students.Add(student);
            
        }

        public static Student GetStudentById(Guid id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public static void UpdateStudent(Student editedStudent)
        {
            Guid id = editedStudent.Id;
            _students[_students.IndexOf(_students.FirstOrDefault(s => s.Id == id))] = editedStudent;
        }

        public static void DeleteStudent(Student deletedStudent)
        {
            int index = _students.IndexOf(deletedStudent);
            _students.RemoveAt(index);
        }

        public static void CreateStudent(Student newStudent)
        {
           newStudent.Id = new Guid();
            _students.Add(newStudent);
        }

    }
}
