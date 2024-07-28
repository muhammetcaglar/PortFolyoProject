using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
