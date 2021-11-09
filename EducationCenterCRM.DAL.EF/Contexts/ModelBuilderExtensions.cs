using System;
using System.Collections.Generic;
using EducationCenterCRM.BLL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace EducationCenterCRM.DAL.EF.Contexts
{
    public static class ModelBuilderExtensions

    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var topic1 = new Topic()
            {
                Id = Guid.NewGuid(),
                Title = ".Net",
                Description = ".Net (ASP.NET, Unity)"
            };
            var topic2 = new Topic()
            {
                Id = Guid.NewGuid(),
                Title = "Frontend",
                Description = "JS, HTML, CSS"
            };

            modelBuilder.Entity<Topic>().HasData(topic1, topic2);

            var course1 = new Course()
            {
                Id = Guid.NewGuid(),
                Title = "Introduction to C#",
                Description = "Introduction to C#",
                Program = "1. Getting Started",
                TopicId = topic1.Id,
                Price = 1250,
                DurationWeeks = 12
            };

            var course2 = new Course()
            {
                Id = Guid.NewGuid(),
                Title = "Introduction to Web",
                Description = "Introduction to Java",
                Program = "1. Getting Started",
                TopicId = topic2.Id,
                Price = 1550,
                DurationWeeks = 4
            };

            var course3 = new Course()
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET",
                Description = "Web with ASP.NET",
                Program = "1. Controllers and MVC 2. WebAPI 3.Angular",
                TopicId = topic1.Id,
                Price = 1350,
                DurationWeeks = 16
            };

            var course4 = new Course()
            {
                Id = Guid.NewGuid(),
                Title = "Unity",
                Description = "Unity Game Development",
                Program = "1. What is Unity",
                TopicId = topic1.Id,
                Price = 1850,
                DurationWeeks = 16
            };


            modelBuilder.Entity<Course>().HasData(course1, course2, course3, course4);

            //init data teachers
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

            var teachers = new List<Teacher>() { teacher1, teacher2, teacher3 };

            foreach (var teacher in teachers)
            {
                teacher.Email = teacher.FirstName + "_" + teacher.LastName + "@gmail.com";
                Random random = new Random();
                string code = string.Empty;
                var codeOption = random.Next(4);
                switch (codeOption)
                {
                    case 0:
                        code = "(25)";
                        break;
                    case 1:
                        code = "(29)";
                        break;
                    case 2:
                        code = "(33)";
                        break;
                    case 3:
                        code = "(44)";
                        break;
                }

                teacher.Phone = "+375" + code + random.Next(1000000, 9999999).ToString();
            }

            modelBuilder.Entity<Teacher>().HasData(teachers);

            var group1 = new StudentGroup()
            {
                Id = Guid.NewGuid(),
                Title = "ASP_21-1",
                TeacherId = teacher1.Id,
                CourseId = course3.Id
            };

            var group2 = new StudentGroup()
            {
                Id = Guid.NewGuid(),
                Title = "ASP_21-2",
                TeacherId = teacher2.Id,
                CourseId = course3.Id
            };

            var group3 = new StudentGroup()
            {
                Id = Guid.NewGuid(),
                Title = "JS_21-1",
                TeacherId = teacher3.Id,
                CourseId = course2.Id
            };

            modelBuilder.Entity<StudentGroup>().HasData(group1, group2, group3);

            //init data students

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
                BirthDate = new DateTime(1998, 6, 15),
                StartDate = new DateTime(2021, 7, 3),
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
                BirthDate = new DateTime(1995, 1, 5),
                StartDate = new DateTime(2021, 9, 3),
                StudentGroupId = group3.Id
            };

            var student7 = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = "Alexander",
                LastName = "Ptichkin",
                Gender = Gender.Male,
                BirthDate = new DateTime(1991, 04, 16),
                StartDate = new DateTime(2021, 9, 3),
                StudentGroupId = group3.Id
            };

            var students = new List<Student>() { student1, student2, student3, student4, student5, student6, student7 };

            foreach (var student in students)
            {
                student.Email = student.FirstName + "_" + student.LastName + "@gmail.com";
                Random random = new Random();
                string code = string.Empty;
                var codeOption = random.Next(4);
                switch (codeOption)
                {
                    case 0:
                        code = "(25)";
                        break;
                    case 1:
                        code = "(29)";
                        break;
                    case 2:
                        code = "(33)";
                        break;
                    case 3:
                        code = "(44)";
                        break;
                }

                student.Phone = "+375" + code + random.Next(1000000, 9999999).ToString();
            }


            modelBuilder.Entity<Student>().HasData(students);

            var passHasher = new PasswordHasher<IdentityUser>();

            var adminUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@ECCRM.com",
                NormalizedUserName = "admin@ECCRM.com".ToUpper(),
                Email = "admin@ECCRM.com",
                NormalizedEmail = "admin@ECCRM.com".ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),

            };

            adminUser.PasswordHash = passHasher.HashPassword(adminUser, "Admin_123456");

            var managerUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "manager@ECCRM.com",
                NormalizedUserName = "manager@ECCRM.com".ToUpper(),
                Email = "manager@ECCRM.com",
                NormalizedEmail = "manager@ECCRM.com".ToUpper(),
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            managerUser.PasswordHash = passHasher.HashPassword(managerUser, "Manager_123456");

            var teacherUsers = new List<IdentityUser>();
            foreach (var teacher in teachers)
            {
                var email = teacher.Email;
                if (!string.IsNullOrEmpty(email))
                {
                    var teacherUser = new IdentityUser()
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserName = email,
                        NormalizedUserName = email.ToUpper(),
                        Email = email,
                        NormalizedEmail = email.ToUpper(),
                        EmailConfirmed = true,
                        SecurityStamp = Guid.NewGuid().ToString()
                    };
                    var password = teacher.FirstName + teacher.LastName;
                    teacherUser.PasswordHash = passHasher.HashPassword(teacherUser, password);
                    teacherUsers.Add(teacherUser);
                }
            }

            modelBuilder.Entity<IdentityUser>().HasData(adminUser, managerUser);

            if (teacherUsers.Count > 0)
            {
                modelBuilder.Entity<IdentityUser>().HasData(teacherUsers);
            }

            var lesson1 = new Lesson()
            {
                Id = Guid.NewGuid(),
                GroupId = group1.Id,
                LessonDate = DateTime.Today.AddDays(-2)
            };

            var lesson2 = new Lesson()
            {
                Id = Guid.NewGuid(),
                GroupId = group1.Id,
                LessonDate = DateTime.Today.AddDays(-3)
            };

            var lesson3 = new Lesson()
            {
                Id = Guid.NewGuid(),
                GroupId = group1.Id,
                LessonDate = DateTime.Today.AddDays(-5)
            };

            modelBuilder.Entity<Lesson>().HasData(lesson1, lesson2, lesson3);

            var mark1 = new Mark()
            {
                Id = Guid.NewGuid(),
                LessonId = lesson1.Id,
                StudentId = student1.Id,
                Score = 8
            };
            var mark2 = new Mark()
            {
                Id = Guid.NewGuid(),
                LessonId = lesson1.Id,
                StudentId = student2.Id,
                Score = 7
            };
            var mark3 = new Mark()
            {
                Id = Guid.NewGuid(),
                LessonId = lesson2.Id,
                StudentId = student1.Id,
                Score = 9
            };
            var mark4 = new Mark()
            {
                Id = Guid.NewGuid(),
                LessonId = lesson2.Id,
                StudentId = student2.Id,
                Score = 7
            };

            var mark5 = new Mark()
            {
                Id = Guid.NewGuid(),
                LessonId = lesson3.Id,
                StudentId = student2.Id,
                Score = 7
            };

            modelBuilder.Entity<Mark>().HasData(mark1, mark2, mark3, mark4, mark5);
        }
    }
}