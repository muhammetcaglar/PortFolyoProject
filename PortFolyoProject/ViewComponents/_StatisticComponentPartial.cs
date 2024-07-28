using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

        return View(); 
        }
    }
}
