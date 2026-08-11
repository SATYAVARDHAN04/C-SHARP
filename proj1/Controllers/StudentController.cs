using Microsoft.AspNetCore.Mvc;
using proj1.Models;

namespace proj1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student();

            student.Id = 101;
            student.Name = "Rahul";
            student.Age = 21;
            student.Course = "C# and .NET";
            student.Marks = 89.5;

            return View(student);
        }
    }
}