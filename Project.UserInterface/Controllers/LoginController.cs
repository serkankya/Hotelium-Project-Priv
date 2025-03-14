﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.EntityLayer.Concrete;
using Project.UserInterface.DTOs.LoginDto;

namespace Project.UserInterface.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username!, loginUserDto.Password!, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Staff");
            }

            return View();
        }
    }
}
