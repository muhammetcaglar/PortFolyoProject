using Microsoft.AspNetCore.Mvc;
using PortFolyoProject.DAL.Context;

namespace PortFolyoProject.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {


        MyPortfolioContext projectContext = new MyPortfolioContext();
        public IViewComponentResult Invoke() {
            var values = projectContext.Portfolios.ToList();
            return View(values); 
        }
    }
}
