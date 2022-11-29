using Microsoft.AspNetCore.Mvc;
using CourseRegistration.Models;
namespace CourseRegistration.Controllers
{
    public class StudentLoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Verify(StudentLogin login)
        {
            return View();
        }
    }
}
