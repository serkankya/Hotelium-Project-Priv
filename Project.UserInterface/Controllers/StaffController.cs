using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.Controllers
{
	public class StaffController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
