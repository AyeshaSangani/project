using Microsoft.AspNetCore.Mvc;

namespace eproject.Controllers
{
    public class ContactUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
