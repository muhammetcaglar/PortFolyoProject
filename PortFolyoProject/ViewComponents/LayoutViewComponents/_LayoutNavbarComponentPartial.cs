using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
