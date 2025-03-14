using Microsoft.AspNetCore.Mvc;

namespace Project.UserInterface.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
