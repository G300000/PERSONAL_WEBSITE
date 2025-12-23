using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}