using Microsoft.AspNetCore.Mvc;
using PortFolyoProject.DAL.Context;

namespace PortFolyoProject.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MyPortfolioContext testimonialContext = new MyPortfolioContext();
        public IViewComponentResult Invoke() {

            var values = testimonialContext.Testimonials.ToList();
            return View(values);
        
        }
    }
}
