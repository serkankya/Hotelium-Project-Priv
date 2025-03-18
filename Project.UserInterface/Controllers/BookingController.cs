using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.Controllers
{
	public class BookingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
