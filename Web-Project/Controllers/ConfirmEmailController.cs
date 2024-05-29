using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using MimeKit;
=======
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
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
<<<<<<< HEAD
            var email = TempData["Email"];
            var ID = TempData["ID"];
            ViewBag.ID = ID;    
            ViewBag.Email = email;
=======
            var value = TempData["Email"];
            var ID = TempData["ID"];
            ViewBag.ID = ID;    
            ViewBag.Email = value;
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> ConfirmEmail(ConfirmEmail confirmEmail)
        {
<<<<<<< HEAD
            Users u = new Users();
=======
            Users u=new Users();
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
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
<<<<<<< HEAD
       
=======

>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
    }
}
