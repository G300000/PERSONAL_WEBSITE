using Microsoft.AspNetCore.Mvc;
using PersonalSite.Models;

namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var profile = new Profile
            {
                Name = "Sheun Georrel Pre",
                Course = "Bacherlor of Science in Computer Science",
                Description = "I love exploring technologies, learning about coding and AI, and building cool designs and projects."
            };

            return View(profile);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}