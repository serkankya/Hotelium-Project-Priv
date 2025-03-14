using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.ViewComponents.Default
{
	public class _HeadPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
