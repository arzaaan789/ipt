using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CourseRegistration.Controllers
{
    public class AdminLoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        void connectionString()
        {

        }
        public IActionResult Verify(AdminLogin login)
        {
            return View();
        }
    }
}
