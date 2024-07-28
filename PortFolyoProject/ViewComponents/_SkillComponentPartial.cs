using Microsoft.AspNetCore.Mvc;
using PortFolyoProject.DAL.Context;

namespace PortFolyoProject.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {   
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var values = context.Skills.ToList();
            return View(values); 
        }
    }
}
