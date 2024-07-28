using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
