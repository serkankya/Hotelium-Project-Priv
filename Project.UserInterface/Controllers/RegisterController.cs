using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.EntityLayer.Concrete;
using Project.UserInterface.DTOs.RegisterDto;

namespace Project.UserInterface.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(InsertUserDto insertUserDto)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			var appUser = new AppUser
			{
				Name = insertUserDto.Name,
				Surname = insertUserDto.Surname,
				Email = insertUserDto.Email,
				UserName = insertUserDto.Username
			};

			var result = await _userManager.CreateAsync(appUser, insertUserDto.Password!);

			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Login");
			}

			return View();
		}
	}
}
