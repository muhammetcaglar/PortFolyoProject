using Microsoft.AspNetCore.Mvc;
using PortFolyoProject.DAL.Context;

namespace PortFolyoProject.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext experienceContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = experienceContext.Experiences.ToList();
            return View(values);
        }
    }
}
