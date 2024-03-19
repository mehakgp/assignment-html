using Microsoft.AspNetCore.Mvc;
using SchoolManagement.BusinessLayer;
using SchoolManagement.Models;
using SchoolManagement.ModelView;
using System.Diagnostics;

namespace SchoolManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBusiness _business;

        public HomeController(ILogger<HomeController> logger, IBusiness business)
        {
            _logger = logger;
            _business = business;
        }


        public IActionResult StudentList()
        {
            List<StudentModel> students = _business.GetAllStudents();
            return View(students);
        }

        public IActionResult TeacherList()
        {
            List<TeacherModel> teachers = _business.GetAllTeachers();
            return View(teachers);
        }

        public IActionResult CourseList()
        {
            List<CourseModel> courses = _business.GetAllCourses();
            return View(courses);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
