using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
