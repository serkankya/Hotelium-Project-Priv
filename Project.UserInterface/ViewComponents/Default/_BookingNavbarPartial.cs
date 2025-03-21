using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.ViewComponents.Default
{
	public class _BookingNavbarPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
