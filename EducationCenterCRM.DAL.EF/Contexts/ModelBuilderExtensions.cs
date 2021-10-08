using System;
using EducationCenterCRM.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace EducationCenterCRM.DAL.EF.Contexts
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var teacher1 = new Teacher()
            {
                Id = Guid.NewGuid(),
                FirstName = "Petr",
                LastName = "Reshetnikov",
                Gender = Gender.Male,
                LinkToProfile = "https://www.linkedin.com/feed/",
                BirthDate = new DateTime(1986, 5, 18),
                Bio = "Some information"

            };
            var teacher2 = new Teacher()
            {
                Id = Guid.NewGuid(),
                FirstName = "Mikhail",
                LastName = "Andreev",
                Gender = Gender.Male,
                LinkToProfile = "https://www.linkedin.com/feed/",
                BirthDate = new DateTime(1989, 1, 23),
                Bio = "Some other information"
            };
            var teacher3 = new Teacher()
            {
                Id = Guid.NewGuid(),
                FirstName = "Natalia",
                LastName = "Usovich",
                Gender = Gender.Female,
                LinkToProfile = "https://www.linkedin.com/feed/",
                BirthDate = new DateTime(1989, 1, 23),
                Bio = "Some other information"
            };

            modelBuilder.Entity<Teacher>().HasData(teacher1, teacher2, teacher3);

            var group1 = new StudentGroup()
            {
                Id = Guid.NewGuid(),
                Title = "ASP_21-1",
                TeacherId = teacher1.Id
            };

            var group2 = new StudentGroup()
            {
                Id = Guid.NewGuid(),
                Title = "ASP_21-2",
                TeacherId = teacher2.Id
            };

            var group3 = new StudentGroup()
            {
                Id = Guid.NewGuid(),
                Title = "JS_21-1",
                TeacherId = teacher3.Id
            };

            modelBuilder.Entity<StudentGroup>().HasData(group1, group2, group3);

            var student1 = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = "Vasilii",
                LastName = "Petrov",
                Gender = Gender.Male,
                BirthDate = new DateTime(1999, 10, 10),
                StartDate = new DateTime(2021, 7, 3),
                StudentGroupId = group1.Id
            };

            var student2 = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = "Petr",
                LastName = "Vasiliev",
                Gender = Gender.Male,
                BirthDate = new DateTime(1998,6, 15),
                StartDate = new DateTime(2021,7, 3),
                StudentGroupId = group1.Id
            };

            var student3 = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = "Ivan",
                LastName = "Bezfamilnyi",
                Gender = Gender.Male,
                BirthDate = new DateTime(1989, 10, 6),
                StartDate = new DateTime(2021, 7, 7),
                StudentGroupId = group2.Id
            };

            var student4 = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = "Mariya",
                LastName = "Sidorova",
                Gender = Gender.Female,
                BirthDate = new DateTime(1989, 11, 8),
                StartDate = new DateTime(2021, 7, 7),
                StudentGroupId = group2.Id
            };

            var student5 = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = "Vitali",
                LastName = "Lukyanov",
                Gender = Gender.Male,
                BirthDate = new DateTime(1989, 12, 5),
                StartDate = new DateTime(2021, 9, 3),
                StudentGroupId = group3.Id
            };

            var student6 = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = "Elvira",
                LastName = "Zaytseva",
                Gender = Gender.Male,
                BirthDate = new DateTime(1995,1, 5),
                StartDate = new DateTime(2021, 9, 3),
                StudentGroupId = group3.Id
            };
            
            modelBuilder.Entity<Student>().HasData(student1, student2, student3, student4, student5, student6);

            //var adminRole = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            //var managerRole = new Role { Id = Guid.NewGuid(), Name = "Manager" };
            //var studentRole = new Role { Id = Guid.NewGuid(), Name = "Student" };
            //var teacherRole = new Role { Id = Guid.NewGuid(), Name = "Teacher" };

            //modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, managerRole, studentRole, teacherRole });
            
            //var admin = new User({Id =  new Guid(), Email = "admin@gmail.com", RoleId = adminRole.Id});

        }
    }
}