using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Entities;

namespace WebApp.Controllers
{
    public class LogOutController : Controller
    {
        private readonly SignInManager<UserEntity> _signInManager;

        public LogOutController(SignInManager<UserEntity> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            await _signInManager.SignOutAsync(); 
            return RedirectToAction("Index", "Home");
        }
    }
}
