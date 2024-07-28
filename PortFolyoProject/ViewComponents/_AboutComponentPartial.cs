using Microsoft.AspNetCore.Mvc;
using PortFolyoProject.DAL.Context;

namespace PortFolyoProject.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {

        MyPortfolioContext aboutContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {

            ViewBag.aboutTitle = aboutContext.Abouts.Select(x => x.Ttile).FirstOrDefault();
            ViewBag.aboutSubDescription = aboutContext.Abouts.Select(x => x.SubsDescription).FirstOrDefault();
            ViewBag.aboutDetail = aboutContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
