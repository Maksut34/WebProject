using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Web_Entity.Models;
using Web_Project.Models;

namespace Web_Project.Controllers
{
    public class ResetPasswordController : Controller
    {
        private readonly UserManager<Users> _users;

        public ResetPasswordController(UserManager<Users> user)
        {
            _users=user;
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (Email == null)
            {
                ModelState.AddModelError("", "Email giriniz!");
                return View();
            }
            var use = await _users.FindByEmailAsync(Email);
            if (use == null)
            {
                ModelState.AddModelError("", "Email bulunamadı!");
                return View();
            }
            var code = await _users.GeneratePasswordResetTokenAsync(use);
            TempData["token"]=code;
            //var back = Url.Action("ResetPassword", "ResetPassword", new
            //{
            //    token= code
            //});

            Random random = new Random();
            Users users = new Users();

            int sayı = random.Next(10, 99);

            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressfrom = new MailboxAddress("Admin", "mesut34ozdemir34@gmail.com");
            MailboxAddress mailboxAddressto = new MailboxAddress("User", use.Email);

            mimeMessage.From.Add(mailboxAddressfrom);
            mimeMessage.To.Add(mailboxAddressto);

            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = "Onay kodunuz!:" + sayı;
            mimeMessage.Body = bodybuilder.ToMessageBody();

            mimeMessage.Subject = "'Yazan' için onay kodu";

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("mesut34ozdemir34@gmail.com", "vzqcdswkgcoqdxjj");
                client.Send(mimeMessage);
                client.Disconnect(true);
            }

            TempData["Email"] = "Kodun gönderildiği email!:" + use.Email;
            TempData["ID"] = use.Id;
            TempData["Code"] = Convert.ToInt32(sayı);

            return RedirectToAction("ConfirmResetPasswordEmail", "ResetPassword");
        }
        [HttpGet]
        public IActionResult ConfirmResetPasswordEmail()
        {
            var value = TempData["Email"];
            var ID = TempData["ID"];
            ViewBag.ID = ID;
            ViewBag.Email = value;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ConfirmResetPasswordEmail(ConfirmEmail confirmEmail)
        {
            int code =Convert.ToInt32(TempData["Code"]);
            Users u = new Users();
            u.Id = confirmEmail.ID;
            var ıd = await _users.FindByIdAsync(u.Id.ToString());
            if (code == confirmEmail.confirmcode)
            {
                return RedirectToAction("ResetPassword", "ResetPassword");
            }
            else
            {
                ModelState.AddModelError("", "Yanlış code!");
            }

            return View();
        }
        [HttpGet]
        public IActionResult ResetPassword()
        {
            string token = TempData["token"].ToString();
            var model= new ResetPassword() { resettoken = token };
            ViewBag.token = model;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPassword resettoken)
        {
            if (!ModelState.IsValid)
            {
                return View(resettoken);
            }

            var user = await _users.FindByEmailAsync(resettoken.email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email bulunamadı!");
                return View(resettoken);
            }
            else
            {
                var result = await _users.ResetPasswordAsync(user, resettoken.resettoken, resettoken.password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login","Login");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(resettoken);
                }
            }
        }
    }
}
