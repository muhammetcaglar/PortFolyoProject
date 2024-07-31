using Microsoft.AspNetCore.Mvc;

namespace PortFolyoProject.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
