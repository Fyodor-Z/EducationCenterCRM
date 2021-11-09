using EducationCenterCRM.MVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace EducationCenterCRM.Tests
{
    public class CoursesControllerTests
    {
        [Fact]
        public void IndexReturnsAViewResultWithAListOfCourses()
        {
            // Arrange
            var courseService = new Mock<IEntityService<Course>>();
            var topicService = new Mock<IEntityService<Topic>>();
            var mapper = new Mock<IMapper>();
            CoursesController controller = new CoursesController(courseService.Object, topicService.Object, mapper.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result.Result);
            var model = Assert.IsAssignableFrom<IEnumerable<CourseModel>>(viewResult.Model);
        }
    }
}
