using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult _AdminLayout()
		{
			return View();
		}
	}
}
