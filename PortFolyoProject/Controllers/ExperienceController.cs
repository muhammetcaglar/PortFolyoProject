using Microsoft.AspNetCore.Mvc;
using PortFolyoProject.DAL.Context;
using PortFolyoProject.DAL.Entities;

namespace PortFolyoProject.Controllers
{
    public class ExperienceController : Controller
    {

        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
        public IActionResult CreateExperience() { 

            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

	}
}
