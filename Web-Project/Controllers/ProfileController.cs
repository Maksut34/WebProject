using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using Web_Entity.Models;

namespace Web_Project.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<Users> _user;
        public ProfileController(UserManager<Users> user) 
        {
            _user = user;
        }
        [Authorize]
        public async Task<IActionResult> Profile()
        {
            if (User.Identity.IsAuthenticated)
            {
                ModelState.AddModelError("", "Kullanıcı aktif!");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı aktif değil!");
            }
            return View();
        }
    }
}
