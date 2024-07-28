using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View(); 
        
        }
    }
}
