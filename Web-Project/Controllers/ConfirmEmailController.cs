using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Web_BLL.Abstract;
using Web_Entity.Models;
using Web_Project.Models;

namespace Web_Project.Controllers
{
    public class ConfirmEmailController : Controller
    {

        private readonly UserManager<Users> _users;
        private readonly IUsersService _usersService;
        public ConfirmEmailController(UserManager<Users> user,IUsersService usersService)
        {
            _users = user;
            _usersService = usersService;
        }
        [HttpGet]
        public IActionResult ConfirmEmail()
        {
            var value = TempData["Email"];
            var ID = TempData["ID"];
            ViewBag.ID = ID;    
            ViewBag.Email = value;
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> ConfirmEmail(ConfirmEmail confirmEmail)
        {
            Users u=new Users();
            u.Id = confirmEmail.ID;
            var ıd = await _users.FindByIdAsync(u.Id.ToString());
            if (ıd.confirmemailcode == confirmEmail.confirmcode)
            {
                ıd.EmailConfirmed = true;

                await _users.UpdateAsync(ıd);

                return RedirectToAction("Tebrikler", "ConfirmEmail");
            }
            else
            {
                ModelState.AddModelError("", "Yanlış code!");
            }

            return View();
        }
        public IActionResult Tebrikler()
        {
            return View();
        }
       
    }
}
