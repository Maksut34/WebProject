using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using MimeKit;
using System;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using Web_BLL.Abstract;
using Web_BLL.Concreate;
using Web_DTO.Concreate;
using Web_DTO.DTO.UsersRegisterDTO;
using Web_Entity.Models;
using Web_Project.Models;

=======
using Web_Project_API.Identity;
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb

namespace Web_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
<<<<<<< HEAD
        Users newuser;
        Random random = new Random();
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;

        private readonly IPlayerWorldMapTransformService _playerWorldMapTransformService;

        public UsersController(UserManager<Users> userManager, SignInManager<Users> signInManager
            ,IPlayerWorldMapTransformService playerWorldMapTransformService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _playerWorldMapTransformService= playerWorldMapTransformService;
=======
        private readonly UserManager<IdentityUsers> _userManager;
        public UsersController(UserManager<IdentityUsers> userManager)
        {
            _userManager = userManager;
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        }


        [HttpGet]
<<<<<<< HEAD
        public async Task<ActionResult<IEnumerable<UsersManager>>> GetUsers()
        {
            var user = _userManager.Users.FirstOrDefault();  // getAll() metodunu çağırıyoruz.
            if (user == null)
=======
        public async Task<ActionResult<IEnumerable<IdentityUsers>>> GetUsers()
        {
            if (_userManager.Users == null)
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
            {
                return NotFound();
            }

<<<<<<< HEAD
            return Ok(user);
        }
        [HttpGet("getuser/{id}")]
        public async Task<ActionResult<UsersManager>> GetuserbyID(int id)
        {
            var user = _userManager.Users.FirstOrDefault(i => i.Id == id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpGet("username/{username}")]
        public async Task<ActionResult<UsersManager>> Getuserbyusername(string username)
        {

            var user = _userManager.Users.FirstOrDefault(i => i.UserName == username);

            if (user == null)
            {
                return NotFound();
            }
            
            return Ok(user);
        }
        [HttpGet("GetUserEmail/{Email}")]
        public async Task<ActionResult<UsersManager>> GetUserByEmail(string Email)
        {

            var user = _userManager.Users.FirstOrDefault(i => i.Email == Email);

            if (user == null)
            {
                return NotFound();
            }
            if(user.Email != null)
            {
                await SendPassworToEmail(user.Email,user.ConfirmPassword);
                return Ok(user);
            }
            return BadRequest("Görünüşe göre böyle bir hesap yok veya bulunamadı!");
        }
        public async Task<bool> SendPassworToEmail(string email, string password)
        {
            try
            {
                // MimeMessage oluştur
                MimeMessage mimeMessage = new MimeMessage();

                // Gönderen ve Alıcı adreslerini belirle
                mimeMessage.From.Add(new MailboxAddress("ozdemirgames", "mesut34ozdemir34@gmail.com"));
                mimeMessage.To.Add(new MailboxAddress("User", email));

                // E-posta içeriğini oluştur
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Şifreniz: " + password;
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                // E-posta konusunu belirle
                mimeMessage.Subject = "Dünyalar Savaşı oyunu şifreniz!";

                // SMTP sunucusuna bağlan ve e-postayı gönder
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("mesut34ozdemir34@gmail.com", "vzqcdswkgcoqdxjj");
                    client.Send(mimeMessage);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {    
                return false;
            }
        }
        [HttpGet("SendConfirmCode/{username}")]
        public async Task<ActionResult<UsersManager>> SendConfirmCode(string username)
        {

            var user = _userManager.Users.FirstOrDefault(i => i.UserName == username);

            if (user == null)
            {
                return NotFound();
            }
            if (user != null)
            {
                await SendConfirmationEmail(user.Email, user.confirmemailcode);
                return Ok(user);
            }
            return BadRequest();
        }
        [HttpPost("authenticate")]
        public async Task<ActionResult<UsersManager>> AuthenticateUser([FromBody] UserCredentials credentials)
        {
            var user = await _userManager.FindByNameAsync(credentials.Username);

            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı");
            }

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, credentials.Password, false);

            if (!signInResult.Succeeded||!user.EmailConfirmed)
            {
                return Unauthorized("Geçersiz kullanıcı adı veya parola.. Yada doğrulanmamış email!");
            }
            else
                return Ok(user);
        }
        
        public class UserCredentials
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        [HttpPost]
        public async Task<ActionResult<UsersManager>> PostUser(RegisterModels model)
        {
            // Şifre ve ConfirmPassword eşleşmesini kontrol et
            if (model.Password != model.confirmpassword)
            {
                return BadRequest("Şifre ve şifre onayı eşleşmiyor.");
            }

            var userUsername= _userManager.Users.FirstOrDefault(i=>i.UserName==model.Username);
            var userEmail= _userManager.Users.FirstOrDefault(i=>i.Email==model.Email);
            if (userUsername == null&&userEmail==null)
            {
                // Kullanıcı oluşturma
               newuser = new Users()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    UserName = model.Username,
                    Email = model.Email,
                    Password = model.Password,
                    ConfirmPassword = model.confirmpassword,
                    confirmemailcode = random.Next(10, 99), // Rastgele bir confirmemailcode oluştur
                                                            //UsersInformationId = 0
                };

                var result = await _userManager.CreateAsync(newuser, model.Password);
                if (result.Succeeded)
                {
                    var worldmaptransfom = new PlayerWorldMapTransform()
                    {
                        worlMaptransformIsHome = true,
                        worlMaptransformIsLittleForest = false,
                        UserId = newuser.Id
                    };
                    await _playerWorldMapTransformService.AddAsync(worldmaptransfom);

                    var emailResult = await SendConfirmationEmail(newuser.Email, newuser.confirmemailcode);

                    if (!emailResult)
                    {

                        // E-posta gönderme başarısız
                        return StatusCode(500, "E-posta gönderme işlemi başarısız.");
                    }
                }
                // Kullanıcı oluşturma sonucunu kontrol et
                if (!result.Succeeded)
                {
                    // Hataları döndür
                    return BadRequest(result.Errors);
                }

                // E-posta gönderme işlemini gerçekleştir

                
            }
            else
            {
                return BadRequest("Email veya username başkası tarafından kullanılıyor!");
            }
            return CreatedAtAction(nameof(AuthenticateUser), new { id = newuser.Id }, newuser);
        }

        public async Task<bool> SendConfirmationEmail(string email, int confirmEmailCode)
        {
            try
            {
                // MimeMessage oluştur
                MimeMessage mimeMessage = new MimeMessage();

                // Gönderen ve Alıcı adreslerini belirle
                mimeMessage.From.Add(new MailboxAddress("ozdemirgames", "mesut34ozdemir34@gmail.com"));
                mimeMessage.To.Add(new MailboxAddress("User", email));

                // E-posta içeriğini oluştur
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Email doğrulama kodunuz: " + confirmEmailCode;
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                // E-posta konusunu belirle
                mimeMessage.Subject = "Web_Project Email Doğrulama Kodu";

                // SMTP sunucusuna bağlan ve e-postayı gönder
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("mesut34ozdemir34@gmail.com", "vzqcdswkgcoqdxjj");
                    client.Send(mimeMessage);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Hata durumunda false döndür
                Console.WriteLine("Hata oluştu: " + ex.Message);
                return false;
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult>PutUser(int id, Users model)
        {
            if (id !=model.Id)
            {
                return BadRequest("Şifre ve şifre onayı eşleşmiyor.");
            }

            var user=await _userManager.Users.FirstOrDefaultAsync(i=>i.Id == id);
            user.UserName=model.UserName;
            user.Email=model.Email;
            user.Surname=model.Surname;
            user.Name = model.Name;

            try
            {
                await _userManager.UpdateAsync(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_userManager==null)
            {
                return NotFound();
            }

            var user = await _userManager.Users.FirstOrDefaultAsync(i => i.Id == id);

            if (user == null)
            {
                return NotFound();
            }
            _userManager.DeleteAsync(user);
            return NoContent();
        }

        [HttpPut("ActivateUser/{id}")]
        public async Task<IActionResult> ActivateUser(int id)
        {
           
            var user = await _userManager.Users.FirstOrDefaultAsync(i => i.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            // Kullanıcının durumunu güncelle
            if(user.userIsActive == true)
                user.userIsActive = false;
            else user.userIsActive = true;

            try
            {
                // Veritabanında güncelleme işlemini gerçekleştir
                await _userManager.UpdateAsync(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Kullanıcı durumu güncelleme işlemi başarısız oldu.");
            }

            return NoContent();
        }
        [HttpPut("ConfirmUserEmail/{username}")]
        public async Task<IActionResult> ConfirmUserEmail(string username)
        {

            var user = await _userManager.Users.FirstOrDefaultAsync(i => i.UserName == username);

            if (user == null)
            {
                return NotFound();
            }

            // Kullanıcının durumunu güncelle
            user.EmailConfirmed= true;

            try
            {
                // Veritabanında güncelleme işlemini gerçekleştir
                await _userManager.UpdateAsync(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Kullanıcı durumu güncelleme işlemi başarısız oldu.");
            }

            return NoContent();
        }

=======
            return await _userManager.Users.ToListAsync();
        }
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
    }
}
