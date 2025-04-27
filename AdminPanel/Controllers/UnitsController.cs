using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class UnitsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
