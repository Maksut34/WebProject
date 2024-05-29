
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net.Mail;
using Web_BLL.Abstract;
using Web_DTO.DTO.UsersRegisterDTO;
using Web_Entity.Models;

namespace Web_Project.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class RegisterController : Controller
    {
        Random random = new Random();
        private readonly UserManager<Users> _user;
<<<<<<< HEAD
        public RegisterController(UserManager<Users> user)
        {
=======
        private readonly IUsersService _usersService;
        public RegisterController(UserManager<Users> user,IUsersService usersService)
        {
            _usersService = usersService;
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
            _user = user;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UsersRegisterDTO usersRegisterDTO)
        {
            try
            {
                if (usersRegisterDTO.ConfirmPassword==usersRegisterDTO.Password)
                {
<<<<<<< HEAD
=======


>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
                    if (ModelState.IsValid)
                    {
                        Users users = new Users();


                        if (await _user.FindByEmailAsync(usersRegisterDTO.Email) != null)
                        {
                            ModelState.AddModelError("", "Email zaten var!");
                        }
                        else
                        {
<<<<<<< HEAD
=======
                            
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
                            users.Name = usersRegisterDTO.Name;
                            users.Email = usersRegisterDTO.Email;
                            users.UserName = usersRegisterDTO.Username;
                            users.Surname = usersRegisterDTO.Surname;
                            users.ConfirmPassword = usersRegisterDTO.ConfirmPassword;
<<<<<<< HEAD
                            users.confirmemailcode = random.Next(10, 99);
=======
                            users.confirmemailcode = random.Next(100000, 1000000);
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
                            var resault = await _user.CreateAsync(users, usersRegisterDTO.Password);

                            if (resault.Succeeded)
                            {
                                MimeMessage mimeMessage = new MimeMessage();
                                MailboxAddress mailboxAddressfrom = new MailboxAddress("Admin", "mesut34ozdemir34@gmail.com");
                                MailboxAddress mailboxAddressto = new MailboxAddress("User", users.Email);

                                mimeMessage.From.Add(mailboxAddressfrom);
                                mimeMessage.To.Add(mailboxAddressto);

                                var bodybuilder = new BodyBuilder();
                                bodybuilder.TextBody = "Onay kodunuz!:" + users.confirmemailcode;
                                mimeMessage.Body = bodybuilder.ToMessageBody();

                                mimeMessage.Subject = "Web_Project Onay kodu";

                                using (var client = new MailKit.Net.Smtp.SmtpClient())
                                {
                                    client.Connect("smtp.gmail.com", 587, false); 
                                    client.Authenticate("mesut34ozdemir34@gmail.com", "vzqcdswkgcoqdxjj"); 
                                    client.Send(mimeMessage); 
                                    client.Disconnect(true);
                                }

                                TempData["Email"]="Kodun gönderildiği email!:"+users.Email;
                                TempData["ID"] = users.Id;

                                return RedirectToAction("ConfirmEmail", "ConfirmEmail");
                            }
                            else
                            {
                                foreach (var item in resault.Errors)
                                {
                                    ModelState.AddModelError("", item.Description);
                                }

                            }
                        }
<<<<<<< HEAD
                    }
                    else
                    {
                        ModelState.AddModelError("", "Bütün alanları doldurunuz!");
=======


>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Şifreler eşleşmiyor.");
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                string errorMessage = ex.Message;
            }
            return View();
        }
=======

                string errorMessage = ex.Message;
            }



            return View();
        }

>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        
    }
}
