using Microsoft.AspNetCore.Mvc;

namespace eproject.Controllers
{
    public class CustomerCare : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
