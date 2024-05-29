using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Web_BLL.Abstract;
using Web_BLL.Concreate;
using Web_DTO.DTO.UsersLoginDTO;
using Web_Entity.Models;

namespace Web_Project.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class LoginController : Controller
    {
        private readonly UserManager<Users> _users;
        private readonly SignInManager<Users> _signInManager;

        private readonly IUsersService _usersManager;
        public LoginController(UserManager<Users> users, IUsersService usersManager, SignInManager<Users> signInManager)
        {
            _users = users;
            _usersManager = usersManager;
            _signInManager = signInManager;

        }
        [HttpGet]
<<<<<<< HEAD
        public IActionResult Login()
        {
            return View();
            
=======
        public IActionResult Login(/*string ReturnUrl=null*/)
        {
            return View(/*new UsersLoginDTO(*/);
            //{
            //    ReturnUrl= ReturnUrl
            //});
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        }
        [HttpPost]
        public async Task <IActionResult> Login(UsersLoginDTO usersLoginDTO,Users u)
        {

            usersLoginDTO.RememberMe = null;
            var signInResult = await _signInManager.PasswordSignInAsync(usersLoginDTO.Username, usersLoginDTO.Password, false, true);
            if (signInResult.Succeeded)
            {
                var user = await _users.FindByNameAsync(u.UserName);

                if (user.EmailConfirmed == true)
                {
<<<<<<< HEAD
                    return RedirectToAction("Anasayfa", "Home");
=======
                    return RedirectToAction("Profile", "Profile");
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb

                }
                else
                {
                    ModelState.AddModelError("", "Görünüşe göre email doğrulanmamış! Lütfen önce emailinizi gelen kod ile doğrulayın!");
                }
            }

            else
            {
                ModelState.AddModelError("", "Giriş başarısız oldu! Hatalı kullanıcı veya şifre.");
            }
            return View();
        }
<<<<<<< HEAD

=======
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        
        [HttpPost]
        public async Task<ActionResult> OturumuKapat()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }
    }
}
