using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
