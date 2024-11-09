using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Andrew Midthun",
                DateOfBirth = new DateTime(1997,01,23)
            };
            return View(data);
        }
    }
}
