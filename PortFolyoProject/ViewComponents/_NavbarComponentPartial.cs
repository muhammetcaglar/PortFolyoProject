using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
