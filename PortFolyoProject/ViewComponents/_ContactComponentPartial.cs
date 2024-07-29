using Microsoft.AspNetCore.Mvc;
using PortFolyoProject.DAL.Context;

namespace PortFolyoProject.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPortfolioContext contactContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = contactContext.Contacts.ToList();
           return View(values); 
        }
    }
}
