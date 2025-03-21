using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.ViewComponents.Default
{
	public class _BookingReservationPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
