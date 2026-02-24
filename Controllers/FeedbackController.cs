using Microsoft.AspNetCore.Mvc;

namespace eproject.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Feedback()
        {
            return View();
        }
    }
}
