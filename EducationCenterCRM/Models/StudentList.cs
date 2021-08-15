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
            new Student(){id = 1, FirstName = "Petr", LastName = "Ivanov", BirthDate = DateTime.Today, StartDate = DateTime.Today},
            new Student(){id = 2, FirstName = "Ivan", LastName = "Petrov", BirthDate = DateTime.Today, StartDate = DateTime.Today}
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

        public static Student GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.id == id);
        }

        public static void UpdateStudent(Student editedStudent)
        {
            int id = editedStudent.id;
            _students[_students.IndexOf(_students.FirstOrDefault(s => s.id == id))] = editedStudent;
        }

        public static void DeleteStudent(Student deletedStudent)
        {
            int index = _students.IndexOf(deletedStudent);
            _students.RemoveAt(index);
        }

        public static void CreateStudent(Student newStudent)
        {
            var newId = _students.Select(s => s.id).Max() + 1;
            newStudent.id = newId;
            _students.Add(newStudent);
        }

    }
}
