using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
